using NUnit;
using System.IO.Packaging;
using System.Xml.Serialization;

using Lab1_Problem1;
using Lab1_Problem2;
using Lab1_Problem3;
using Lab1_Problem4;
using Package = Lab1_Problem2.Package;

namespace Lab2Testing

{
    public class Tests
    {
       // [SetUp]
       // public void Setup(){}

        [Test]
        public void Test_Problem1()
        {
            BankCharges testAccount = new BankCharges();
            int checks = 19;
            decimal balance = 390.00M;
            testAccount.SetNumberOfChecks(checks);
            testAccount.SetAccountBalance(balance);

            decimal accountFees = 19 * 0.10M + 10 + 15;
            decimal newBalance = balance - accountFees;
            

            Assert.That(testAccount.CalcCheckFees() == 19 * 0.10M);
            Assert.That(testAccount.CalcCharges() == accountFees);

            testAccount.executeCharges();
            Assert.That(testAccount.GetAccountBalance() == newBalance);

        }

        [Test]
        public void Test_Problem2()
        {
            double weight_kg = 6;
            double distance_miles = 510;
            Package package = new Package(weight_kg, distance_miles);
            decimal expectedPrice = 2.20M * 2;
            decimal expectedRate = 2.20M;

            Assert.That(package.GetRate() == expectedRate);
            Assert.That(package.CalcPrice() == expectedPrice);
        }

        [Test]
        public void Test_Problem3()
        {
            int startingPop = 1;
            int days = 9;
            double avgDailyPopGrowth = 1;
            int expectedFinalPopulation = 512;
            Population population = new Population(startingPop, avgDailyPopGrowth, days);
            int finalPopulation = population.calcDailyPop()[8];
            Assert.That(expectedFinalPopulation == finalPopulation);
        }
    }
}