//OnCampus.CS

using StudentNamespace;

namespace OnCampusNamespace
{
    public class OnCampus : Student
    {
        readonly double housingFee;
        const double PARIS_FEE = 6000;
        const double ROME_FEE = 6500;
        const double LONDON_FEE = 5000;

        public OnCampus(string sName, string ID, int sCredits, HousingType sHouse)
            : base(sName, ID, sCredits)
        {
            housingFee = sHouse == HousingType.London ? LONDON_FEE : sHouse == HousingType.Paris ? PARIS_FEE : ROME_FEE;
        }

        protected override double TotalFeeCalc()
        {
            return credits + housingFee;
        }

        public override string ToString()
        {
            string output = base.ToString();
            double feeTotal = TotalFeeCalc();

            output += $"Housing Costs:\t{housingFee:C}\r\n";
            output += $"Total Fee:\t{feeTotal:C}\r\n";

            return output;
        }
    }
}
