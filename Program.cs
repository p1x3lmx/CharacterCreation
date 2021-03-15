using System;

namespace Test_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] characters =  {"elephant", "rhino", "dog", "cat", "owl", "leopard", "tucan", "sloth"};
            string[] profession = {"doctor", "astronaut", "policeman", "fireman", "cableman", "bussinesman" };

            Random randomCharacter = new Random();
            Random randomProfession = new Random();

            for (int i = 0; i < characters.Length; i++)
            {

            Console.WriteLine(profession[randomProfession.Next(0, profession.Length)] + " " + characters[randomCharacter.Next(0, characters.Length)]);

            }
            
        }
    }
}
