namespace getAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast fødselsdato (dd-mm-åååå):");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthdate))
            {
                int age = GetAge(birthdate);
                DisplayAge(age);
            }
            else
            {
                Console.WriteLine("Ugyldigt datoformat. Prøv igen.");
            }
        }

        static int GetAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            if (birthdate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        static void DisplayAge(int age)
        {
            Console.WriteLine($"Alder: {age} år");
        }
    }
    }
