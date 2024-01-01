using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29Console
{
    public interface ISavingsAccount { void PrintAmountData(); }
    public interface IcurrentAccount { void PrintAmountData(); }
    public class Account : ISavingsAccount, IcurrentAccount
    {
        static void Main(string[] args)
        {
            ISavingsAccount sa = new Account(); sa.PrintAmountData();
            IcurrentAccount cs = new Account(); cs.PrintAmountData();

        }
        void IcurrentAccount.PrintAmountData() { Console.WriteLine("current acc interface print data method"); }
        void ISavingsAccount.PrintAmountData()
        {
            Console.WriteLine("Savings acc interface print data method ");
        }
    }
}
