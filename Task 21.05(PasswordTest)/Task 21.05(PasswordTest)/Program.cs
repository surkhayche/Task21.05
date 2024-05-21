namespace Task_21._05_PasswordTest_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();
            ValidatePassword(password);
        }
        static bool ValidatePassword(string password)
        {
            if (password.Length <8)
            {
                return false;
            }
            else if (!char.IsUpper(password[0])) 
            {
                return false;
            }
            else if (password.Contains("!@#$%^&*()_+-=[]|{};:<>?,. "))
            {
                return false;
            }
            return true;
        }
    }
}
