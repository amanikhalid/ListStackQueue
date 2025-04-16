namespace ListTasks
{
    internal class Program
    {
        static List<int> Numbers = new List<int>();
        static List<string> Names = new List<string>();
        static List<int> Elements = new List<int>();
        static List<string> Words = new List<string>();
        static void Main(string[] args)
        {
            int choice = 0;
            while (true)
            {
                Console.WriteLine("1. Add Numbers");
                Console.WriteLine("2. Add Names");
                Console.WriteLine("3. Add Elements");
                Console.WriteLine("4. Add Words");
                Console.WriteLine("5. Show Numbers");
                Console.WriteLine("6. Show Names");
                Console.WriteLine("7. Show Elements");
                Console.WriteLine("8. Show Words");
                Console.WriteLine("9. Exit");
                choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        AddNumbers();
                        break;
                    case 2:
                        AddNames();
                        break;
                    case 3:
                        AddElements();
                        break;
                    case 4:
                        AddWords();
                        break;
                    case 5:
                        ShowNumbers();
                        break;
                    case 6:
                        ShowNames();
                        break;
                    case 7:
                        ShowElements();
                        break;
                    case 8:
                        ShowWords();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void AddNumbers()
        {
            Console.WriteLine("Enter a number to add:");
            int number = int.Parse(Console.ReadLine());
            Numbers.Add(number);
            Console.WriteLine("Number added.");
        }
        static void AddNames()
        {
            Console.WriteLine("Enter a name to add:");
            string name = Console.ReadLine();
            Names.Add(name);
            Console.WriteLine("Name added.");
        }

        static void AddElements()
        {
            Console.WriteLine("Enter an element to add:");
            int element = int.Parse(Console.ReadLine());
            Elements.Add(element);
            Console.WriteLine("Element added.");
        }

        static void AddWords()
        {
            Console.WriteLine("Enter a word to add:");
            string word = Console.ReadLine();
            Words.Add(word);
            Console.WriteLine("Word added.");
        }

        static void ShowNumbers()
        {
            Console.WriteLine("Numbers in the list:");
            foreach (var number in Numbers)
            {
                Console.WriteLine(number); 
            }
        }

        static void ShowNames()
        {
            Console.WriteLine("Names in the list:");
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }

        static void ShowElements()
        {
            Console.WriteLine("Elements in the list:");
            foreach (var element in Elements)
            {
                Console.WriteLine(element);
            }
        }
        static void ShowWords()
        {
            Console.WriteLine("Words in the list:");
            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }




        }
    }
}
