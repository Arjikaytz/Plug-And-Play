namespace MusicProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                         Plug and Play                         ");

            //Electric guitar
            //fender stratocaster
            //fender jaguar
            //fender mustang

            //Acoustic guitar
            //martin D-18E
            //harmony stella
            //1960s epiphone

            //Amplifier
            //Marshall
            //Fender
            //Orange

            Console.WriteLine("Which Instrument You Desired To Play? ");
            Console.WriteLine("1: Electric Guitar");
            Console.WriteLine("2: Acoustic Guitar");

            int guitarInstrument = Convert.ToInt16(Console.ReadLine());
            

            if (guitarInstrument == 1)
            {
                Console.WriteLine("Electric Guitar is Your Choice. ");
                Console.WriteLine("Choose: ");
                string[] actions = new string[] { "1. Fender Stratocaster", "2. Fender Jaguar", "3. Fender Mustang" };
                foreach (var guitar in actions)
                {
                    Console.WriteLine(guitar);
                }
            }
            else if (guitarInstrument == 2)  
            {
                Console.WriteLine("Acoustic Guitar is Your Choice.");
                Console.WriteLine("Choose: ");
                string[] actions2 = new string[] { "1. Martin D-18E", "2. Harmony Stella", "3. 1960s Epiphone" };
                foreach(var guitar2 in actions2)
                {
                    Console.WriteLine(guitar2);
                }
            }
            else
            {
                Console.WriteLine("What?!");
            }
                Console.ReadKey();
        }
    }
}
