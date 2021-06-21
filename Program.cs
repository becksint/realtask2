using System;

namespace Task2
{
    class MainClass : Expense
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Please choose whether you want to buy property or buy a vehicle");//User will choose here between Renting and buying a property

            Console.WriteLine("Press 1 to choose Property");//Buying Property
            Console.WriteLine("Press 2 to choose Buying A Vehicle");//Buying a Vehicle
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    BuyingAProperty(choice);//buying a property
                    break;
                case "2":
                    BuyAVehicle(choice);//buying a vehicle
                    break;
            }
            static void BuyingAProperty(string choice)//property
            {


                //array for expenses
                double[] Expenses = new double[7];

                double Gross_Monthly_Income;
                double Estimated_Monthly_Tax_Deducted;
                double Groceries;
                double Water_and_Lights;
                double Travel_Costs;
                double Cellphone_and_Telephone;
                double Other_Expenses;




                Console.Write("Please enter the value of your Gross Monthly Income: ");//Gross Monthly Income
                Gross_Monthly_Income = Convert.ToInt32(Console.ReadLine());
                Expenses[0] = Gross_Monthly_Income;

                Console.Write("Please enter the value of your Estimated Monthly Tax Deducted: ");//Estimated Monthly Tax Deduction
                Estimated_Monthly_Tax_Deducted = Convert.ToInt32(Console.ReadLine());
                Expenses[1] = Estimated_Monthly_Tax_Deducted;

                Console.Write("Please enter your Estimated Monthly Expenditures for Groceries: ");//Groceries
                Groceries = Convert.ToInt32(Console.ReadLine());
                Expenses[2] = Groceries;

                Console.Write("Please enter your Estimated Monthly EXpenditures for Water and Lights: ");//Water and Lights
                Water_and_Lights = Convert.ToInt32(Console.ReadLine());
                Expenses[3] = Water_and_Lights;

                Console.Write("Please enter your Estimated Monthly Expenditures for Travel Costs(Including Petrol): ");//Travel Costs Including Petrol
                Travel_Costs = Convert.ToInt32(Console.ReadLine());
                Expenses[4] = Travel_Costs;

                Console.Write("Please enter your Estimated Monthly Expenditures for CellPhone and Telephone: ");//Cellphine And Telephone
                Cellphone_and_Telephone = Convert.ToInt32(Console.ReadLine());
                Expenses[5] = Cellphone_and_Telephone;

                Console.Write("Please enter your Estimated Monthly Expenditures for Other Expenses: ");//Other Expenses
                Other_Expenses = Convert.ToInt32(Console.ReadLine());
                Expenses[6] = Other_Expenses;

                Console.WriteLine("===============================================================================================");

                Console.Clear();
                Console.WriteLine("Accommodation\n\n\n");//User will choose here between Renting and buying a property

                Console.WriteLine("Press 1 to choose Renting");//Renting
                Console.WriteLine("Press 2 to choose Buying A Property");//Buying a property


                switch (choice)//for loop
                {
                    case "1"://renting
                        Renting();
                        break;
                    case "2"://buying a property 
                        BuyingAProperty(Gross_Monthly_Income, Estimated_Monthly_Tax_Deducted, Groceries, Water_and_Lights, Travel_Costs, Cellphone_and_Telephone, Other_Expenses);
                        break;

                }
                static void Renting()//renting
                {
                    Console.Clear();
                    Console.WriteLine("Renting\n\n");
                    Console.WriteLine("Please enter monthly rental amount");
                    Decimal Mass = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" \n\n");
                }
                static void BuyingAProperty(double Gross_Monthly_Income, double Estimated_Monthly_Tax_Deducted, double Groceries, double Water_and_Lights, double Travel_Costs, double Cellphone_and_Telephone, double Other_Expenses)
                {
                    double[] HomeLoans = new double[4];//array for home loan 

                    Console.WriteLine("Buying a Property\n This information is needed for your home loan");
                    Console.WriteLine("Please enter the Purchase Price Of The Property");//full price of property 
                    double Mass = Convert.ToInt32(Console.ReadLine());
                    HomeLoans[0] = Mass;
                    Console.WriteLine("Please enter the Total Deposit Amount");//total deposit
                    double DepositMass = Convert.ToInt32(Console.ReadLine());
                    HomeLoans[1] = DepositMass;
                    Console.WriteLine("Please enter the Interest Rate");//interest rate 
                    double InterestMass = Convert.ToInt32(Console.ReadLine());
                    HomeLoans[2] = InterestMass;

                    Console.WriteLine("Please enter the number of months to repay(between 240 and 360)");//monthly repayment
                    double MonthMass = Convert.ToInt32(Console.ReadLine());
                    HomeLoans[3] = MonthMass;

                    double payment = (int)((Mass - DepositMass) * (Math.Pow((1 + InterestMass / 12), MonthMass) * InterestMass) / 12 * (Math.Pow((1 + InterestMass / 12), MonthMass) - 1));
                    double incomeThird = payment / 3;
                    if (payment > incomeThird)
                    {
                        Console.WriteLine("Approval of home loan is unlikely.");//if payment is larger then a third of the income the home loan will be unlikely 
                    }
                    //available money 
                    double availableMoney = Gross_Monthly_Income - (Estimated_Monthly_Tax_Deducted + Groceries + Water_and_Lights + Travel_Costs + Cellphone_and_Telephone + Other_Expenses + payment);

                    Console.WriteLine("After all deductions have been made the available monthly money is: " + availableMoney);


                }


            }

            static void BuyAVehicle(string choice)//buying a Vehicle
            {


                double[] carExpenses = new double[7];

                double ModelandMake;
                double PurchasePrice;
                double TotalDeposit;
                double InterestRate;
                double InsurancePremium;
                double HomeLoanRepayment;
                double TotalMonthlyCost;
                double Income;
                double Dele;



                Console.WriteLine("Please enter the Model and Make of your vehicle: ");
                ModelandMake = Convert.ToDouble(Console.ReadLine());
                carExpenses[0] = ModelandMake;


                Console.WriteLine("Please enter in the Purchase Price of your vehicle: ");
                PurchasePrice = Convert.ToDouble(Console.ReadLine());
                carExpenses[1] = PurchasePrice;


                Console.WriteLine("Please enter in your Total Deposit: ");
                TotalDeposit = Convert.ToDouble(Console.ReadLine());
                carExpenses[2] = TotalDeposit;


                Console.WriteLine("Please enter in your Interest Rate: ");
                InterestRate = Convert.ToDouble(Console.ReadLine());
                carExpenses[3] = InterestRate;


                Console.WriteLine("Please enter in your Estimated Insurance Premium: ");
                InsurancePremium = Convert.ToDouble(Console.ReadLine());
                carExpenses[4] = InsurancePremium;


                Console.WriteLine("Please enter in your Home Loan Repayment: ");
                HomeLoanRepayment = Convert.ToDouble(Console.ReadLine());
                carExpenses[5] = HomeLoanRepayment;


                Console.WriteLine("Please enter in your Total Income: ");
                Income = Convert.ToDouble(Console.ReadLine());
                carExpenses[6] = Income;



                double Calculate = PurchasePrice + TotalDeposit + InsurancePremium;

                Console.WriteLine("Your total monthly cost come to: ");
                TotalMonthlyCost = Calculate + HomeLoanRepayment;
                Dele = TotalMonthlyCost / Income * 100;

                Console.WriteLine("Your Toatl Expenses: ");

                if (Dele > 75)
                {
                    Console.WriteLine("Your Total Expenses exceed 75% of your Income");//notify the user 
                }
                else
                {
                    Console.WriteLine("Your Total Expenses do not exceed 75% of your Income");
                }
                Console.WriteLine("=========================================================================");

                Console.WriteLine("Your Expenses in Descending order: ");//display the expenses in descending order
                Array.Sort(carExpenses);
                Array.Reverse(carExpenses);
                foreach (int value in carExpenses)
                {
                    Console.WriteLine(value + " ");
                }


            }
        }

        public delegate void DisMess(int num);//use a delegate to notify the user 
        public void DisplayMessage(int Dele)

        {


        }
    }
}
    


