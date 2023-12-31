﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Lab1_Problem1
{
    public class BankCharges
    {
        private int numOfChecks;
        private decimal accountBalance;

        public BankCharges()
        {
            this.numOfChecks = 0;
            this.accountBalance = 0;
        }

        public BankCharges(int numOfChecks, decimal accountBalance)
        {
            this.numOfChecks = numOfChecks;
            this.accountBalance = accountBalance;
        }

        public int GetNumberOfChecks() 
        { 
            return numOfChecks; 
        }
        public void SetNumberOfChecks(int numOfChecks) 
        {
            this.numOfChecks = numOfChecks; 
        }
        public decimal GetAccountBalance() 
        {  
            return accountBalance; 
        }

        public void SetAccountBalance(decimal accountBalance) 
        { 
            this.accountBalance = accountBalance; 
        }

        public decimal CalcCharges()
        {
            decimal charge = 10.00M;
            charge += this.CalcCheckFees();
            if (this.accountBalance < 400) { charge += 15.00M; }

            return charge;
        }

        public decimal CalcCheckFees()
        {

            if (this.numOfChecks < 20) { return this.numOfChecks * 0.10M; }
            if (this.numOfChecks < 40) { return this.numOfChecks * 0.08M; }
            if (this.numOfChecks < 60) { return this.numOfChecks * 0.06M; }
            return this.numOfChecks * 0.10M; ;
        }

        public void executeCharges()
        { 
            this.SetAccountBalance(this.GetAccountBalance() - this.CalcCharges());
        }

    }
}
