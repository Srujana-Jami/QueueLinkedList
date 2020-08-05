using System;

namespace QueueLinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, x;

            QueueL qu = new QueueL();

            while(true){
                Console.WriteLine("1.Insert an element in the queue ");
                Console.WriteLine("2.Delete an element from the queue ");
                Console.WriteLine("3.Display element at the front ");
                Console.WriteLine("4.Display al elements of the queue ");
                Console.WriteLine("5.Display size of the queue ");
                Console.WriteLine("6.Quit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the elements in the queue ");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.Insert(x);
                        break;
                    case 2:
                        x = qu.Delete();
                        Console.WriteLine("Element deleted is : " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the top of the queue : " + qu.peek());
                        break;
                    case 4:
                        qu.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of the queue : " + qu.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice ");
                        break;



                }
                Console.WriteLine();
            }
        }
    }
}
