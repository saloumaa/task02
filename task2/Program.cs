int[] numbers= new int[100];
int count = 0; 
string choice;
do
{
    Console.WriteLine("P - Print numbers");
    Console.WriteLine("A - Add a number");
    Console.WriteLine("M - Display mean of the numbers");
    Console.WriteLine("S - Display the smallest number");
    Console.WriteLine("L - Display the largest number");
    Console.WriteLine("Q - Quit");
    Console.WriteLine("===============================");
    Console.Write("Enter your choice: ");
    choice = Console.ReadLine().ToLower();
    switch (choice)
    {
        case "p":
            if (count == 0)
            {
                Console.WriteLine("[] - the array is empty");

            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < count; i++)
                {
                    Console.Write(numbers[i]);
                    if (i < count - 1)
                        Console.Write(" ");
                }
                Console.Write("]");


            }
            break;
        case "a":
            Console.Write("Enter an integer to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num}added");
            break;
        case "m":
            if (count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
                double mean = (double)sum / count;
                Console.WriteLine($"{mean}");
            }
            break;
        case "s":
            if (count == 0) { Console.WriteLine("Unable to determine the smallest number - array is empty"); }
            else
            {
                int smallest = numbers[0];
                for (int i = 1; i < count; i++)
                    if (numbers[i] < smallest)
                        smallest = numbers[i];
                Console.WriteLine($"{smallest}");
            }
            break;
        case "l":
            if (count == 0) { Console.WriteLine("Unable to determine the largest number - array is empty"); }
            else
            {
                int largest = numbers[0];
                for (int i = 1; i < count; i++)
                    if (numbers[i] > largest)
                        largest = numbers[i];
                Console.WriteLine($" {largest}");
            }
            break;
        case "q":
            Console.WriteLine("Goodbye");
            break;
        default:
            Console.WriteLine("Unknown selection, please try again");
            break;

    } 
} while (choice != "q"); 