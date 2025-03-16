using System.Numerics;

namespace exercises.task3.Models
{
    public class Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Card { get; set; }
        public int Pin { get; set; }
        public int Balance { get; set; }
        public Customer(string fName, string lName, string card, int pin, int balace)

        {
            FName = fName;
            LName = lName;
            Card = card;
            Pin = pin;
            Balance = balace;
        }
        public void CardBalance()
        {
            Console.WriteLine($"The current balance from you're account is {Balance}");
        }
        public void CashWithdrawal(string withdraw)
        {
            if (int.TryParse(withdraw, out int userwithdraw))
            {
                if (userwithdraw < Balance)
                {

                    Console.WriteLine($"Your new car balance {Balance -= userwithdraw}");
                    return;
                }
                Console.WriteLine($"You do not have enough money to withdraw, please enter lower than your balance {Balance}");
            }
        }
        public void CashDeposit(string deposit)
        {
            if (int.TryParse(deposit, out int userDeposit))
            {
                Console.WriteLine($"Your new card balance is {Balance += userDeposit}");
                return;
            }
        }
    }
}
