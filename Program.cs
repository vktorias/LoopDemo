using Microsoft.VisualBasic;

namespace LoopDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int myNumber = 0;

            //    while (myNumber <= 5)
            //    {
            //        Console.WriteLine(myNumber);
            //        myNumber++;
            //    }



            //string myPassword = "12345";
            //string userInput = "";

            //do
            //{
            //    Console.WriteLine("Skriv lösenord:");
            //    userInput = Console.ReadLine();

            //} while (userInput != myPassword);


            //int Number = 0;

            //Console.WriteLine("While loop starts here:");
            //while (Number <= 10)

            //{
            //    Console.WriteLine(Number);
            //    Number++;
            //}

            //Console.WriteLine("For loop starts here:");
            //for (int Number1 = 0; Number1 <= 10; Number1++)
            //{
            //    Console.WriteLine(Number1);
            //}


            //Skapar en array med 3 värden. 

            string[] users = { "Aldor", "Reidar", "Anders" };

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}