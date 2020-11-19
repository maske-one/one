const cache_files = [
    /* Runtime Files */
    "_framework/_bin/one.dll",

    "_framework/_bin/Microsoft.AspNetCore.Authorization.dll",
    "_framework/_bin/Microsoft.AspNetCore.Blazor.dll",
    "_framework/_bin/Microsoft.AspNetCore.Blazor.HttpClient.dll",
    "_framework/_bin/Microsoft.AspNetCore.Components.dll",
    "_framework/_bin/Microsoft.AspNetCore.Components.Web.dll",
    "_framework/_bin/Microsoft.AspNetCore.Components.Forms.dll",
    "_framework/_bin/Microsoft.AspNetCore.Metadata.dll",
    "_framework/_bin/Microsoft.Bcl.AsyncInterfaces.dll",
    "_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll",
    "_framework/_bin/Microsoft.Extensions.DependencyInjection.dll",
    "_framework/_bin/Microsoft.Extensions.Logging.Abstractions.dll",
    "_framework/_bin/Microsoft.Extensions.Options.dll",
    "_framework/_bin/Microsoft.Extensions.Primitives.dll",
    "_framework/_bin/Microsoft.JSInterop.dll",
    "_framework/_bin/Mono.Security.dll",
    "_framework/_bin/Mono.WebAssembly.Interop.dll",
    "_framework/_bin/System.Buffers.dll",
    "_framework/_bin/System.ComponentModel.Annotations.dll",
    "_framework/_bin/System.Core.dll",
    "_framework/_bin/System.dll",
    "_framework/_bin/System.Memory.dll",
    "_framework/_bin/System.Net.Http.dll",
    "_framework/_bin/System.Numerics.Vectors.dll",
    "_framework/_bin/System.Runtime.CompilerServices.Unsafe.dll",
    "_framework/_bin/System.Text.Encodings.Web.dll",
    "_framework/_bin/System.Text.Json.dll",
    "_framework/_bin/System.Threading.Tasks.Extensions.dll",
    "_framework/blazor.boot.json",
    "_framework/blazor.server.js",
    "_framework/blazor.webassembly.js",
    "_framework/wasm/mono.js",
    "_framework/wasm/mono.wasm",

    /* Project Files */

    'assets/project_files/addtohomescreen.js',
    'assets/project_files/android-chrome-192x192.png',
    'assets/project_files/android-chrome-512x512.png',
    'assets/project_files/apple-touch-icon.png',
    'assets/project_files/favicon.ico',
    'assets/project_files/favicon-16x16.png',
    'assets/project_files/favicon-32x32.png',
    'assets/project_files/loading.css',
    'assets/project_files/logo.svg',
    'assets/project_files/mstile-150x150.png',
    'assets/project_files/safari-pinned-tab.svg',
    'assets/project_files/styling.css',

    'assets/resources/Plan_2A.svg',

    '404.html',
    'index.html',
    'serviceWorker.js',
    'session.json',
    'manifest.json'
];

var cache_name = 'web-cache';
var resTrack = new Map();
var ignoreRequests = new RegExp('(' + ['/Home/TriggerPush'].join('(\/?)|\\') + ')$');

this.addEventListener('install', function(event) {
  event.waitUntil(
    caches.open(cache_name).then(function(cache) {
      return cache.addAll(cache_files);}));});

this.addEventListener('fetch', function (event) {
    if (ignoreRequests.test(event.request.url)) {
		console.log('ignored: ', event.request.url); return}
    event.respondWith(retrieveFromCache(event));
});

function retrieveFromCache(event) {
    return caches.open(cache_name).then(function (cache) {
        return cache.match(event.request).then(function (response) {
           if (response) {return response;}

        if(navigator.onLine){
            var fetchRequest = event.request.clone();
            return fetch(fetchRequest).then(
                function (response) {
                    if (!response || response.status !== 200 || response.type !== 'basic') {
                        return response;}

                    var responseToCache = response.clone();
                    cache.put(event.request, responseToCache);
                    resTrack.set(event.request.url, new Date().getTime());
                    return response;});
        }else{
            sendNotification("You are offline, you will be redirected to home page.");
            fallback = self.location.origin + '/Home/Fallback';
            return caches.match(fallback);}})})}

this.addEventListener('activate', function(event) {
    var cacheWhitelist = [cache_name];
  event.waitUntil(
    caches.keys().then(function(keyList) {
      return Promise.all(keyList.map(function(key) {
          if (cacheWhitelist.indexOf(key) === -1) {
            return caches.delete(key);}}));}));});

this.addEventListener('message', function(event){processMessage(event.data);});

function send_message_to_client(client, msg){
    return new Promise(function(resolve, reject){
        var msg_chan = new MessageChannel();
        msg_chan.port1.onmessage = function(event){
            if(event.data.error){reject(event.data.error);}
            else{resolve(event.data);}};
        client.postMessage(msg, [msg_chan.port2]);});}

function send_message_to_all_clients(msg){
    clients.matchAll().then(clients => {
        clients.forEach(client => {
            send_message_to_client(client, msg).then(m => this.processMessage(m));})})}

function processMessage(msgObj){
    try{
        if(msgObj.type==1){console.log(msgObj.message);}
    }catch(err)
    {console.log(err);}}

function sendNotification(msg){
    var msgObg ={"type":1,"message":msg}
    send_message_to_all_clients(msgObg);}

self.addEventListener('push', function (event) {
    console.log('[Service Worker] Push Received.');
    console.log(`[Service Worker] Push had this data: "${event.data.text()}"`);
    const title = 'Push cache';
    const options = {body: event.data.text()};
    event.waitUntil(self.registration.showNotification(title, options));
});

var deferredPrompt;

self.addEventListener('beforeinstallprompt', function (e) {
    // Prevent Chrome 67 and earlier from automatically showing the prompt
    e.preventDefault();
    // Stash the event so it can be triggered later.
    deferredPrompt = e;

    showAddToHomeScreen();

});

function showAddToHomeScreen() {

    var a2hsBtn = document.querySelector(".ad2hs-prompt");

    a2hsBtn.style.display = "block";

    a2hsBtn.addEventListener("click", addToHomeScreen);

}

function addToHomeScreen() {
    var a2hsBtn = document.querySelector(".ad2hs-prompt");  // hide our user interface that shows our A2HS button
    a2hsBtn.style.display = 'none';  // Show the prompt
    deferredPrompt.prompt();  // Wait for the user to respond to the prompt
    deferredPrompt.userChoice
        .then(function (choiceResult) {

            if (choiceResult.outcome === 'accepted') {
                console.log('User accepted the A2HS prompt');
            } else {
                console.log('User dismissed the A2HS prompt');
            }

            deferredPrompt = null;

        });
}