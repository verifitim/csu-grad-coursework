/*
 * Project: Assignment Set 4 Program 10
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: PropertyTax
 * Description: Calculates a property's tax
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    #region "Enumeration"
    public enum LocationType
    {
        City = 1,
        Suburb = 2,
        Rural = 3
    }

    #endregion
    internal class PropertyTax
    {
        #region "Constants"

        // building tax rates

        public const decimal buildingRateUnder1000 = 1.11m; // 1-1000 sqft
        public const decimal buildingRate1001To2000 = 1.13m; // 1001-2000 sqft
        public const decimal buildingRate2001To3000 = 1.15m; // 2001-3000 sqft
        public const decimal buildingRate3001To4000 = 1.17m; // 3001-4000 sqft
        public const decimal buildingRateAbove4000 = 1.19m; // 4000+ sqft

        // building tax flat fees

        public const decimal buildingFee1001To2000 = 1110m; // 1001-2000 sqft
        public const decimal buildingFee2001To3000 = 2240m; // 2001-3000 sqft
        public const decimal buildingFee3001To4000 = 3390m; // 3001-4000 sqft
        public const decimal buildingFeeAbove4000 = 4560m; // 4000+ sqft

        // land tax rates

        public const decimal landRateUnder10000 = 0.12m; // 1-1000 sqft
        public const decimal landRate10001To20000 = 0.14m; // 1001-2000 sqft
        public const decimal landRate20001To30000 = 0.16m; // 2001-3000 sqft
        public const decimal landRate30001To40000 = 0.18m; // 3001-4000 sqft
        public const decimal landRateAbove40000 = 0.20m; // 4000+ sqft

        // land tax flat fees

        public const decimal landFee10001To20000 = 1200m; // 1001-2000 sqft
        public const decimal landFee20001To30000 = 2600m; // 2001-3000 sqft
        public const decimal landFee30001To40000 = 4200m; // 3001-4000 sqft
        public const decimal landFeeAbove40000 = 6000m; // 4000+ sqft

        // building tax deducations

        public const decimal buildingYearlyDeductionRate = 0.004m; // 0.04%

        // property tax deductions

        public const decimal landYearlyDeductionRateUnder28000 = 0.0375m; // 3.75%
        public const decimal landYearlyDeductionRateOver28000 = 0.0215m; // 2.15%

        #endregion


        #region "Fields"

        public readonly int BuildingSquareFootage, LandSquareFootage, YearBuilt;
        public readonly LocationType PropertyLocation;
        public readonly string PropertyOwnerName;

        #endregion

        #region "Auto-Implemented Properties"

        public int BuildingAge { get; private set; }
        public decimal BuildingTax { get; private set; }
        public decimal BuildingTaxDeduction { get; private set; }
        public decimal LandTax { get; private set; }
        public decimal LandTaxDeduction { get; private set; }
        public decimal TotalPropertyTax { get; private set; }

        #endregion

        #region "Constructor"

        public PropertyTax (string ownerName, int buildingSize, int landSize,
            int yearBuilt, LocationType whereLocated)
        {
            // local variable

            int currentYear = DateTime.Now.Year;

            // set properties

            PropertyOwnerName = ownerName;
            BuildingSquareFootage = buildingSize;
            LandSquareFootage = landSize;
            YearBuilt = yearBuilt;
            PropertyLocation = whereLocated;

            BuildingAge = currentYear - YearBuilt;

            // calculate total property tax

            CalcTotalPropertyTax();

        }

        #endregion

        #region "Methods"

        public void CalcBuildingTax()
        {
            // local variable

            decimal rate;

            // calculateb uilding tax rate based on building square footage

            switch (BuildingSquareFootage)
            {
                case <= 1000:
                    rate = buildingRateUnder1000 * BuildingSquareFootage;
                    break;
                case <= 2000:
                    rate = buildingFee1001To2000 + buildingRate1001To2000 * BuildingSquareFootage;
                    break;
                case <= 3000:
                    rate = buildingFee2001To3000 + buildingRate2001To3000 * BuildingSquareFootage;
                    break;
                case <= 4000:
                    rate = buildingFee3001To4000 + buildingRate3001To4000 * BuildingSquareFootage;
                    break;
                default:
                    rate = buildingFeeAbove4000 + buildingRateAbove4000 * BuildingSquareFootage;
                    break;
            }

            // set building tax rate property

            BuildingTax = rate;
        }

        public void CalcLandTax()
        {
            // local variable

            decimal rate;

            // calculate land tax rate based on square footage

            switch (LandSquareFootage)
            {
                case <= 1000:
                    rate = landRateUnder10000 * LandSquareFootage;
                    break;
                case <= 2000:
                    rate = landFee10001To20000 + landRate10001To20000 * LandSquareFootage;
                    break;
                case <= 3000:
                    rate = landFee20001To30000 + landRate20001To30000 * LandSquareFootage;
                    break;
                case <= 4000:
                    rate = landRate30001To40000 + landRate30001To40000 * LandSquareFootage;
                    break;
                default:
                    rate = landFeeAbove40000 + landRateAbove40000 * LandSquareFootage;
                    break;
            }

            // set land tax rate property

            LandTax = rate;

        }

        public void CalcBuildingTaxDeducation()
        {
            // local variable

            decimal deduction;

            // calculate building tax deduction for buildings >15 years old
            
            deduction = BuildingAge * buildingYearlyDeductionRate * BuildingTax;

            // set building tax deduction property

            BuildingTaxDeduction = deduction;
        }

        public void CalcLandTaxDeducation()
        {
            // local variable

            decimal deduction;

            // calculate land tax deduction for rural land based on land size

            if (PropertyLocation == LocationType.Rural)
            {
                if (LandSquareFootage <= 28000)
                {
                    deduction = landYearlyDeductionRateUnder28000 * LandTax;
                }
                else
                {
                    deduction = landYearlyDeductionRateOver28000 * LandTax;
                }
            }
            else
            {
                deduction = 0;
            }

            // set land tax deduction property

            LandTaxDeduction = deduction;
        }

        public void CalcTotalPropertyTax()
        {
            // calculate and set the building and land taxes

            CalcBuildingTax();
            CalcLandTax();

            // calculate building tax deduction for buildings >15 years old
            
            if (BuildingAge > 15)
            { 
                CalcBuildingTaxDeducation();  
            }
            else
            {
                BuildingTaxDeduction = 0;
            }

            // calculate rural type land tax deduction

            if (PropertyLocation == LocationType.Rural)
            {
                CalcLandTaxDeducation();
            }
            else
            {
                LandTaxDeduction = 0;
            }

            // calculate and set total property tax property

            TotalPropertyTax = BuildingTax + LandTax - BuildingTaxDeduction - LandTaxDeduction;

        }

        public override string ToString()
        {
            return $"Building Age: {BuildingAge.ToString()}\n" +
                $"Building Tax: {BuildingTax.ToString("C")}\n" +
                $"Land Tax: {LandTax.ToString("C")}\n" +
                $"Building Tax Deduction: {BuildingTaxDeduction.ToString("C")}\n" +
                $"Land Tax Deduction: {LandTaxDeduction.ToString("C")}\n" +
                $"Total Property Tax: {TotalPropertyTax.ToString("C")}";
        }

        #endregion

    }
}
