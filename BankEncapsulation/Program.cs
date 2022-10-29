namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBank = new BankAccount();

            Console.WriteLine("Enter the Amount you would like to Deposit: ");
            string valueEntered = "";
            double deposit = 0.0;
            bool success = false;

            while (success == false) 
            {
                valueEntered = Console.ReadLine();
                success = double.TryParse(valueEntered, out deposit);
                if (success == false) 
                {
                    Console.WriteLine("Enter the Amount you would like to Deposit: ");

                }
            }
            
            myBank.Deposit(deposit);
            Console.WriteLine("Your new Balance is: ");
            Console.WriteLine(myBank.GetBalance().ToString("C"));

        }
    }
}
