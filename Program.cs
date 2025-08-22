using System.Collections.Generic;

namespace D03_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> operations = new List<int>();
            bool valid = false;

                
            while (!valid)
            {
                Console.WriteLine(" P - print Number \n A - add number \n M - display mean number \n S - display the smallest Number \n L - display the largest number \n F - find number \n C - Clear th whole list \n Q - quit");
                char op = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (op)
                {
                    case 'P':
                        printList(operations);
                        break;
                    case 'A':
                        addToList(operations, 0);
                        Console.Write("Enter The Number : ");
                        int add = Convert.ToInt32(Console.ReadLine());
                        addToList(operations, add);
                        break;
                    case 'M':
                        MeanOfList(operations);
                       
                        break;
                    case 'S':
                        Console.WriteLine($"Smallest {smallest(operations)}");
                        break;
                    case 'L':
                        Console.WriteLine($"Largest {largest(operations)}");

                        break;
                    case 'F':
                        findInList(operations);
                        break;

                    case 'C':

                        operations.Clear();
                        break;
                    case 'Q':
                        valid = true;
                        break;
                    default:
                        valid = true;
                        break;
                }

            static void MeanOfList (List<int> list) {
            double sum = 0.0;
            double average = 0.0;
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
                average = sum / list.Count;
            }
            Console.WriteLine($"Mean {average}");
        }



        static void printList(List<int> list) {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
        static void addToList(List <int> list,int num)
        {
            int add = Convert.ToInt32(Console.ReadLine());
            list.Add(add);

        }
        static int smallest(List<int> list) {

            if (list.Count > 0)
            {
                int smallest = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] < smallest)
                    {
                        smallest = list[i];
                    }
                }
                return smallest;
            }
            else
            {
                return 0;

            }


        }

        static int largest(List<int> list)
        {
            if (list.Count > 0)
            {
                int largest = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] > largest)
                    {
                        largest = list[i];
                    }
                }
                return largest;
            }
            else
            {
                return 0;
            }
        }

        static void findInList(List <int> list)
        {
            if (list.Count > 0)
            {
                Console.Write("Enter The Number that you want to find it : ");
                int find = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == find)
                    {
                        Console.WriteLine($"The number {find} is found at index {i}");
                        break;
                    }
                    else if (i == list.Count - 1)
                    {
                        Console.WriteLine($"The number {find} is not found in the list.");
                    }
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
    }
}
