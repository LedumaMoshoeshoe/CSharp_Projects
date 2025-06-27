double grossMonthlyIncome;
double taxDeducted;
double rentAmount;
double purchasePrice;
double deposit;
double interestRate;
int monthsToRepay;
double[] monthlyExpenditures = new double[5]; // to store monthly expenditures in various categories
double homeLoanRepayment;
double availableMonthlyMoney;

Console.WriteLine("Welcome to the Rent or Buy Property Application!");
Console.Write("Please enter your gross monthly income (before deductions): ");
grossMonthlyIncome = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your estimated monthly tax deducted: ");
taxDeducted = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter your estimated monthly expenditures in the following categories:");
Console.Write("Housing: ");
monthlyExpenditures[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Transportation: ");
monthlyExpenditures[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Food: ");
monthlyExpenditures[2] = Convert.ToDouble(Console.ReadLine());
Console.Write("Utilities: ");
monthlyExpenditures[3] = Convert.ToDouble(Console.ReadLine());
Console.Write("Other: ");
monthlyExpenditures[4] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Would you like to rent or buy a property? Enter 'r' for rent or 'b' for buy: ");
string input = Console.ReadLine();

if (input == "r")
{
    Console.Write("Please enter the monthly rental amount: ");
    rentAmount = Convert.ToDouble(Console.ReadLine());

    // Calculate available monthly money after deductions
    availableMonthlyMoney = grossMonthlyIncome - taxDeducted - monthlyExpenditures.Sum() - rentAmount;

    Console.WriteLine($"Your available monthly money after deductions is: {availableMonthlyMoney:C}");
}
else if (input == "b")
{
    Console.Write("Please enter the purchase price of the property: ");
    purchasePrice = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please enter the total deposit: ");
    deposit = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please enter the interest rate: ");
    interestRate = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please enter the number of months to repay: ");
    monthsToRepay = Convert.ToInt32(Console.ReadLine());

    // Calculate home loan repayment
    double loanAmount = purchasePrice - deposit;
    double monthlyInterestRate = interestRate / 1200;
    homeLoanRepayment = loanAmount * monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -monthsToRepay));

    // Check if home loan repayment is more than a third of gross monthly income
    if (homeLoanRepayment > grossMonthlyIncome / 3)
    {
        Console.WriteLine("Your home loan repayment is more than a third of your gross monthly income. Approval of the home loan is unlikely.");
    }
    else
    {
        // Calculate available monthly money after deductions and home loan repayment
        availableMonthlyMoney = grossMonthlyIncome - taxDeducted - monthlyExpenditures.Sum() - homeLoanRepayment;
        Console.WriteLine($"Your available monthly money after deductions and home loan repayment is: {availableMonthlyMoney:C}");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter 'r' for rent or 'b' for buy.");
}
