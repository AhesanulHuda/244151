using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
   public class Account
    {
        public string accountNo;
        public string customerName;
        public int blances=500;
        public int amount;
       public int damount;
       public int wamount;
        string report;
        public string createAcc()
        {
            string createAccountName = accountNo + customerName;
            return createAccountName;
        }

        public int Deposit()
        {
             damount = blances + amount;
            return damount;
        }

        public int Withdraw()
        {
            wamount = blances - amount;
            return wamount;
        }

        public string Report()
        {
            report = "MR." + customerName + "Your Account No IS" + accountNo + " your amount Dipojit balance is" + wamount + " your Withdraw blances is" + wamount + " Thank You";
            return report;
        }
    }
}
