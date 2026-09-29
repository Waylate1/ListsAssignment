List<int> MyNumbers = new List<int>();
int Running = 1;
while (Running == 1)
{
    Console.WriteLine("Would you like to add or remove an item from your current list");
    Console.WriteLine("Press 1 to add a new number");
    Console.WriteLine("Press 2 to remove a new number");
    Console.WriteLine("Press 3 to view your list");
    Console.WriteLine("Press 4 to exit");
    int Input = Int32.Parse(Console.ReadLine());
    switch (Input)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Please sumbit the number you want to add");
            MyNumbers.Add(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            break;
            //sorry i dont know how to make it so you cant try to remove a number that does not exist
        case 2:
            Console.Clear();
            Console.WriteLine("Please enter the number you want to remove");
            if (MyNumbers.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("There are no numbers currently in the list");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                break;
            }
            MyNumbers.Remove(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            break;

        case 3:
            if (MyNumbers.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("There are no numbers currently in the list");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                break;
            }
            Console.Clear();
            for (int i = 0; i < MyNumbers.Count; i++)
            {
                Console.WriteLine("Your numbers are:");
                Console.WriteLine(MyNumbers[i]);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            break;

        case 4:
            Console.WriteLine("Exiting");
            int Delay = 2000;
            Thread.Sleep(Delay);
            Running = 0;
            break;
    }
}
