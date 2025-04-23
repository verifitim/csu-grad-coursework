/*
 * Project: Assignment Set 4 Program 9
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: Conference
 * Description: Calculates conference charges for CSU Conference Services
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    #region "Enumeration"

    public enum AccommodationType
    {
        Single = 1,
        Double = 2,
        Suite = 3
    }

    #endregion
    internal class Conference
    {
        #region "Constants"

        const decimal singleRate = 76.45m;
        const decimal doubleRate = 51.93m;
        const decimal suiteRate = 116.72m;

        const decimal accommodationDiscount = 0.15m;
        const decimal internetAccessRate = 8.22m;
        const int minAttendeesForDiscount = 60;
        const int minNightsForDiscount = 7;
        const decimal optionalServicesDiscount = 0.0825m;
        const decimal recreationCenterAccessRate = 7.74m;

        #endregion

        #region "Fields"

        private int numberOfAttendees, numberOfNights;
        private AccommodationType accommodationChoice;
        private bool internetAccess, recreationCenterAccess;

        #endregion

        #region "Properties"

        public int NumberOfAttendees
        {
            get
            { 
                return numberOfAttendees;
            }
            set 
            { 
                numberOfAttendees = value;
                CalcConferenceCharges();
            }
        }
        public int NumberOfNights
        {
            get
            {
                return numberOfNights;
            }
            set
            {
                numberOfNights = value;
                CalcConferenceCharges();
            }
        }
        public AccommodationType AccommodationChoice
        {
            get
            {
                return accommodationChoice;
            }
            set
            {
                accommodationChoice = value;
                CalcConferenceCharges();
            }
        }
        public bool InternetAccess
        {
            get
            {
                return internetAccess;
            }
            set
            {
                internetAccess = value;
                CalcConferenceCharges();
            }
        }
        public bool RecreationCenterAccess
        {
            get
            {
                return recreationCenterAccess;
            }
            set
            {
                recreationCenterAccess = value;
                CalcConferenceCharges();
            }
        }

        #endregion

        #region "Auto-Implemented Properties"

        public string ConferenceName { get; set; }
        public decimal AccommodationCharge { get; private set; }
        public decimal OptionalServicesCharge { get; private set; }
        public decimal Discount { get; private set; }
        public decimal TotalCharge { get; private set; }

        #endregion

        #region "Constructor"

        public Conference(string confName, int numAttendees, int numNights,
            AccommodationType accommodation, bool internet, bool recCenter)
        {
            ConferenceName = confName;
            NumberOfAttendees = numAttendees;
            NumberOfNights = numNights;
            AccommodationChoice = accommodation;
            InternetAccess = internet;
            RecreationCenterAccess = recCenter;
        }

        #endregion

        #region "Methods"

        private decimal ReturnAccommodationRate()
        {
            decimal rate = 0;

            switch (AccommodationChoice)
            {
                case AccommodationType.Single:
                    rate = singleRate;
                    break;
                case AccommodationType.Double:
                    rate = doubleRate;
                    break;
                case AccommodationType.Suite:
                    rate = suiteRate;
                    break;
            }

            return rate;
        }

        private void CalcConferenceCharges()
        {
            // local variables

            decimal accommodationRate, internetAccessCharge, recCenterAccessCharge;


            // calculate and set AccommodationCharge

            accommodationRate = ReturnAccommodationRate();

            AccommodationCharge = accommodationRate * NumberOfAttendees * NumberOfNights;


            // calculate and set OptionalServicesCharge

            if (InternetAccess == true)
            {
                internetAccessCharge = internetAccessRate * NumberOfAttendees * numberOfNights;
            }
            else
            {
                internetAccessCharge = 0;
            }

            if (RecreationCenterAccess == true)
            {
                recCenterAccessCharge = recreationCenterAccessRate * NumberOfAttendees * numberOfNights;
            }
            else
            {
                recCenterAccessCharge = 0;
            }

            OptionalServicesCharge = internetAccessCharge + recCenterAccessCharge;

            // calculate and set Discount

            if (NumberOfAttendees >= minAttendeesForDiscount & numberOfNights >= minNightsForDiscount)
            {
                Discount = (accommodationDiscount * AccommodationCharge) + (optionalServicesDiscount * OptionalServicesCharge);
            }

            // calculate and set TotalCharge

            TotalCharge = AccommodationCharge + OptionalServicesCharge - Discount;
        }

        public override string ToString()
        {
            return $"Accommodation Charge: {AccommodationCharge.ToString("C")}\n" +
                $"Optional Services Charge: {OptionalServicesCharge.ToString("C")}\n" +
                $"Discount Amount: {Discount.ToString("C")}\n" +
                $"Total Charge: {TotalCharge.ToString("C")}";
        }

        #endregion
    }
}
