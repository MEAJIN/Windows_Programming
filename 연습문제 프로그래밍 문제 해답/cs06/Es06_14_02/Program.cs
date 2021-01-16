﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Es06_14_02
{
    class Account
    {
        private double balance;
        public Account(double initialDeposit)
        {
            balance = initialDeposit;
        }
        public double Balance
        {
            get { return balance; }
            // set { balence = value; }
        }
        public void Deposit(double amount)
        {
            lock (this)
            {
                // balance += amount;

                double temp;
                temp = balance;
                Thread.Sleep(1000);
                balance = temp + amount; // 처리 시간을 늘릴려고 딜레이를 주는 코드로 변경
            }
        }
    }
    class Teller
    {
        string name;
        Account account;
        double amount;
        public Teller(string name, Account account, double amount)
        {
            this.name = name;
            this.account = account;
            this.amount = amount;
        }
        public void TellerTask()
        {
            account.Deposit(amount);
            Console.WriteLine(name + " : " + account.Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000000);
            Teller teller1 = new Teller("Teller1", account, 1000000);
            Teller teller2 = new Teller("Teller2", account, 2000000);
            Thread tTeller1 = new Thread(new ThreadStart(teller1.TellerTask));
            Thread tTeller2 = new Thread(new ThreadStart(teller2.TellerTask));
            tTeller1.Start();
            tTeller2.Start();
        }
    }
}
