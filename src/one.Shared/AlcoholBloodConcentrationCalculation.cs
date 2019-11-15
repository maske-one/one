using System;

namespace one.Shared
{
    public class AlcoholBloodConcentrationCalculation
    {
        private const double DensityBlood = 1.055;
        private const double DensityAlcohol = 0.7893;
        private const double WaterInBloodFactor = 0.8;
        private const double StomachFillFactor = 0.32;

        private static readonly GenderConstants MaleGenderConstants = new GenderConstants(2.447, 0.09516, 0.1074, 0.3362);
        private static readonly GenderConstants FemaleGenderConstants = new GenderConstants(0.203, 0.07, 0.1069, 0.2466);

        public AlcoholBloodConcentrationCalculation(Genders gender, int age, double height, double weight,
            double deciliter, double percent, int fullness)
        {
            Gender = gender;
            Age = age;
            Height = height;
            Weight = weight;
            Deciliter = deciliter;
            Percent = percent;
            Fullness = fullness;
        }

        public Genders Gender { get; set; }
        public double Age { get; set;  }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Deciliter { get; set; }
        public double Percent { get; set; }
        public int Fullness { get; set; }

        public double Result
        {
            get
            {
                var genderConstants = Gender==Genders.Female ? FemaleGenderConstants : MaleGenderConstants;
                var totalBodyWater = genderConstants.Offset 
                                     - genderConstants.WeightAge * Age 
                                     + genderConstants.WeightHeight * Height 
                                     + genderConstants.WeightWeight * Weight;
                var alcoholAmountGrams = DensityAlcohol * Deciliter * Percent;
                var alcoholAbsorptionReductionFactor = Math.Pow(Math.E, StomachFillFactor * Math.Sqrt(Fullness / 3));
                return WaterInBloodFactor * alcoholAmountGrams / ( alcoholAbsorptionReductionFactor * DensityBlood * totalBodyWater);
            }
        }
        //PE Watson, R Watson, RD Batt: Total body water volumes for adult males and females estimated from simple antropometric measurements. The American Journal of Clinical Nutrition 33: JANUARY 1980, S. 27–39. PMID 6986753
        //https://de.wikipedia.org/wiki/Blutalkoholkonzentration

        private struct GenderConstants
        {
            public GenderConstants(double offset, double weightAge, double weightHeight, double weightWeight)
            {
                Offset = offset;
                WeightAge = weightAge;
                WeightHeight = weightHeight;
                WeightWeight = weightWeight;
            }
            
            public readonly double Offset;
            public readonly double WeightAge;
            public readonly double WeightHeight;
            public readonly double WeightWeight;
        }

        //var reductionFactor = DensityBlood * totalBodyWater / (0.8 * Weight);
    }
}