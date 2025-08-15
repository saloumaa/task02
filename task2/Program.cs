List<int> mylist = new List<int>();
string choice;

do
{
    Console.WriteLine("P - Print numbers");
    Console.WriteLine("A - Add a number");
    Console.WriteLine("M - Display mean of the numbers");
    Console.WriteLine("S - Display the smallest number");
    Console.WriteLine("L - Display the largest number");
    Console.WriteLine("F - Find a number");
    Console.WriteLine("C - Clear the list");
    Console.WriteLine("Q - Quit");
    Console.WriteLine("===============================");
    Console.Write("Enter your choice: ");
    choice = Console.ReadLine().ToLower();

    switch (choice)
    {
        case "p":
            if (mylist.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < mylist.Count; i++)
                {
                    Console.Write(mylist[i]);
                    if (i < mylist.Count - 1)
                        Console.Write(" ");
                }
                Console.WriteLine("]");
            }
            break;

        case "a":
            Console.Write("Enter an integer to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            mylist.Add(num);
            Console.WriteLine($"{num} added");
            break;

        case "m":
            if (mylist.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < mylist.Count; i++)
                    sum += mylist[i];
                double mean = (double)sum / mylist.Count;
                Console.WriteLine($"{mean:F2}");
            }
            break;

        case "s":
            if (mylist.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            }
            else
            {
                int smallest = mylist[0];
                for (int i = 1; i < mylist.Count; i++)
                    if (mylist[i] < smallest)
                        smallest = mylist[i];
                Console.WriteLine(smallest);
            }
            break;

        case "l":
            if (mylist.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
            }
            else
            {
                int largest = mylist[0];
                for (int i = 1; i < mylist.Count; i++)
                    if (mylist[i] > largest)
                        largest = mylist[i];
                Console.WriteLine(largest);
            }
            break;

        case "f":
            if (mylist.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Enter number to search: ");
                int searchNum = Convert.ToInt32(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < mylist.Count; i++)
                {
                    if (mylist[i] == searchNum)
                    {
                        Console.WriteLine($"{searchNum} found at index {i}");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"{searchNum} not found");
                }
            }
            break;

        case "c":
            mylist.Clear();
            Console.WriteLine("List cleared");
            break;

        case "q":
            Console.WriteLine("Goodbye");
            break;

        default:
            Console.WriteLine("Unknown selection, please try again");
            break;
    }
} while (choice != "q");