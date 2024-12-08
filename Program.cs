using System.ComponentModel.Design;
using System.Security.Cryptography;

class program
{
    List<string> Expenses = new List<string>();
    List<double> amount = new List<double>();


    // Main menu
   public void Menu()
    {
        program pi = new program();
        while (true)
        {
            Console.WriteLine("" +
            "1. Add Expenses\n" +
            "2. Remove Expenses\n" +
            "3. View Expenses\n" +
            "4. Calculate Total\n" +
            "5. Exit\n");
            Console.WriteLine("Input your answer\n");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput == null)
            {
                Console.WriteLine("Your answer can not be blank!\n");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            if (userInput == 1)
            {
                pi.AddExpense();
            }
            if (userInput == 2)
            {
                pi.RemoveExpense();
            }
            if (userInput == 3)
            {
                pi.ViewExpenses();
            }
            if (userInput == 4)
            {
                pi.CalculateExpenses();
            }
            if (userInput == 5)
            {
                break;
            }
        }
    }
    // Add expenses to the expense list and the amount list
    void AddExpense()
    {
        Console.WriteLine("Enter the name of the Item you purchased or the expense: \n");
        string expense = Console.ReadLine();
        Console.WriteLine("Enter the price or monthly cost of the item or expense: \n");
        double itemPrice = Convert.ToDouble(Console.ReadLine());
        while (expense == null || itemPrice == null)
        {
            if (expense == "")
            {
                Console.WriteLine("Expense name can not be left empty\n");
                expense = Console.ReadLine();
            }
            else if (itemPrice == null)
            {
                Console.WriteLine("Item / Expense price can not be left empty\n");
                itemPrice = Convert.ToInt32(Console.ReadLine());
            }
        }
        Expenses.Add(expense);
        amount.Add(itemPrice);
    }
    // remove expenses from the expenses list
    void RemoveExpense()
    {
        for (int i = 0; i < Expenses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Expenses[i]} - ${amount[i]}\n");
        }
        Console.WriteLine("Enter the number of the item that you want to remove\n");
        int removeItem = Convert.ToInt32(Console.ReadLine());
        Expenses.RemoveAt(removeItem - 1);
        amount.RemoveAt(removeItem - 1);
        Console.WriteLine($"Item: {removeItem} has been removed from your expenses\n");
    }
    // View all input expenses 
    void ViewExpenses()
    {
        for (int i = 0; i < Expenses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Expenses[i]} - ${amount[i]}\n");
        }
    }
    // Calculate expenses 
    void CalculateExpenses()
    {
        double totalCount = amount.Sum();
        Console.WriteLine($"Your total amount of expenses are ${totalCount}\n");
    }


    static void Main(string[] args)
    {
        program programInst = new program();
        programInst.Menu();
    }
}
