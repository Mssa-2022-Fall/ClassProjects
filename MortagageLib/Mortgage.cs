﻿namespace MortagageLib
{
    public class Mortgage
    {
        public DateTime OriginationDate;
        public decimal OriginalPrincipalAmount;
        public decimal CurrentPrincipal;
        public decimal OriginalInterestRate;
        public MortgageType MortgageType;
        public List<Payment> Payments;

        public Payment CalculateMonthlyPayment(DateTime maturityDate)
        { throw new NotImplementedException(); }
        public Payment CalculateMonthlyPayment(int numberOfPayments)
        { throw new NotImplementedException(); }

        public List<Payment> GetAmortizationSchedule(DateTime maturityDate)
        { throw new NotImplementedException(); }
        public List<Payment> GetAmortizationSchedule(int numberOfPayments)
        { throw new NotImplementedException(); }

        //create a constructor that accept the origination date and an enum
        // for 15 or 30 year, throw exception if origination < today - in the past
        public Mortgage(DateTime mortgageOriginationDate, MortgageDuration duration)
        {
            if (mortgageOriginationDate < System.DateTime.Now) {
                throw new Exception("Mortgage can not be originated in the past.");
            }
            // right click solution -> Add -> New Project -> search for MSTest Project
            // Name the project MortgageLibTest
            // delete UnitTest1.cs
        }
 

    }

    public enum MortgageType
    {
        FixRate,
        AdjustableRate
    }

    // Create enum for 15 Year Mortgage and 30 Year Mortgage
    public enum MortgageDuration
    { 
        FifteenYears,
        ThirtyYears
    }
}