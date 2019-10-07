//STUDENT.CS

using System;

namespace StudentNamespace
{
    public enum HousingType {Paris, Rome, London }

    public abstract class Student
    {
        protected int credits;
        protected double creditFee;
        protected string studentName;
        protected string studentID;

        public Student(string sName, string ID, int sCredits)
        {
            studentName = sName;
            studentID = ID;
            credits = sCredits;
        }

        protected double CreditFeeCalculation()
        {
            return (credits < 15) ? credits * 500 : 7500;
        }

        protected abstract double TotalFeeCalc();
        
        public override string ToString()
        {
            creditFee = CreditFeeCalculation();
            string output;

            output = $"Student Name:{studentName}\tStudent ID: {studentID}\r\n";
            output += $"Credit Hours:\t{credits}\r\n";
            output += $"Credit Costs:\t{creditFee:C}\r\n";

            return output;
        }
    }
}
