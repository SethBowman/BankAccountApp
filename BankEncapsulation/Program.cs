namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var interaction = new UserInteraction();
            var sethsAccount = new BankAccount();
            interaction.ATM(sethsAccount);
        }
    }
}
