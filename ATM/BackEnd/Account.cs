using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Account : Printable
    {
        float balance;
        int AccountNumber;

        public void printReceipt(String receipt)
        {
        base.Print();
        //this method prints receipt
        }

        public float getBalance()
        {
            return balance;
        }
        public int getAccountNumber()
        {
            return AccountNumber;
        }
        
    }

