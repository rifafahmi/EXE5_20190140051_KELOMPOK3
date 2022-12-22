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

}
