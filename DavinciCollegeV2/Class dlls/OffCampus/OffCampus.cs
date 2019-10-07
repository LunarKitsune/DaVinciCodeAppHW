//OffCampus.CS

using StudentNamespace;

namespace OffCampusNamespace
{
    public class OffCampus : Student
    {
        readonly double autoFee;

        public OffCampus(string sName, string ID, int sCredits, bool AutoChecked):
            base(sName, ID, sCredits)
        {
            autoFee = (AutoChecked == true) ? 500 : 0;
        }

        protected override double TotalFeeCalc()
        {
            return credits + autoFee;
        }

        public override string ToString()
        {
            double totalFee;
            string output = base.ToString();

            totalFee = TotalFeeCalc();

            output += $"Auto costs:\t{autoFee:C}\r\n";
            output += $"Total fee:\t\t{totalFee:C}";

            return output;
        }

    }
}
