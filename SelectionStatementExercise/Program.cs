namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1

            var r = new Random();
            int favNumber = r.Next(1, 1000);

            Console.WriteLine("Please pick a number between 1 - 1000");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)

            {
                Console.WriteLine("too low!");
            }

            else if (userInput > favNumber)

            {
                Console.WriteLine("too high");
            }

            else

            {
                Console.WriteLine("You got it!");
            }


            //Exercise 2

            Console.WriteLine("What is your favorite school subject?");

            var favSubject = Console.ReadLine();

            switch (favSubject)

            {
                case "English":
                    Console.WriteLine("absolutely not");
                    break;
                case "History":
                    Console.WriteLine("Power nap time");
                    break;
                case "Math":
                    Console.WriteLine("Possible, let's try more");
                    break;
                case "Science":
                    Console.WriteLine("absolutely not");
                    break;
                case "Political Science":
                    Console.WriteLine("Snake of the world");
                    break;
                default:
                    Console.WriteLine("Have not taken that class yet");
                    break;
            }


        }
    }
}
