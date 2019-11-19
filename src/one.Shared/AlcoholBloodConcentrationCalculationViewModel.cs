using System;
using System.Collections.Generic;
using System.Text;

namespace one.Shared
{
    public class AlcoholBloodConcentrationCalculationViewModel
    {
        private AlcoholBloodConcentrationCalculation _model;

        public AlcoholBloodConcentrationCalculationViewModel(AlcoholBloodConcentrationCalculation model)
        {
            _model = model;
        }

        public string Gender
        {
            get => _model.Gender.ToString();

            set => _model.Gender = (Genders)Int32.Parse(value);
        }

        public double Age
        {
            get => _model.Age;

            set => _model.Age = value;
        }

        public double Height
        {
            get => _model.Height;

            set => _model.Height = value;
        }

        public double Weight 
        {
            get => _model.Weight;

            set => _model.Weight = value;
        }

        public double Deciliter
        {
        get => _model.Deciliter;

        set => _model.Deciliter = value;
        }
        public double Percent
        {
            get => _model.Percent;

            set => _model.Percent = value;
        }
        public double Fullness
        {
            get => _model.Fullness;

            set => _model.Fullness = value/3.0;
        }

        public string ResultText
        {
            get => String.Format("{0:0.00} ‰", _model.Result) ;
        }
    }
}
