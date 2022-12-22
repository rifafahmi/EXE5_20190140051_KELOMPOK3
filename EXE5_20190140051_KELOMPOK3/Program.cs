using System;

namespace EXE5_20190140051_KELOMPOK3
{
    class node
    {
        public string name;
        public node next;



    }
    class queue
    {
        node rifa, fahmi;
        public queue()
        {
            rifa = null;
            fahmi = null;
        }
        public void insert()
        {
            string nm;
            node newNode = new node();
            Console.WriteLine("masukan element: ");
            nm = Console.ReadLine();
            newNode.name = nm;
            newNode.next = null;
            if (rifa == null)
            {
                rifa = newNode;
                fahmi = newNode;
                return;

            }
            rifa.next = newNode;
            rifa = newNode;

        }
        public void delete()
        {
            if (rifa == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            rifa = rifa.next;
            if (rifa == null)
                fahmi = null;
        }
        public void display()
        {
            if (rifa == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            node display;
            for (display = rifa; display != null; display = display.next)
                Console.WriteLine(display.name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}