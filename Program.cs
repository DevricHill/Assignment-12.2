namespace Assignment_12._2
{
    internal class Program
    {
        static void Result()
        {
            LinkedList LL = new LinkedList();
            LL.Add(1);
            LL.Add(2);
            LL.Add(6);
            LL.Add(3);
            LL.Add(4);
            LL.Add(5);
            LL.Add(6);

            LinkedList LL2 = new LinkedList();

            LinkedList LL3 = new LinkedList();
            LL3.Add(7);
            LL3.Add(7);
            LL3.Add(7);
            LL3.Add(7);

            Console.Write("Linked List: ");
            PrintLL(LL);
            LL.Remove(6);
            Console.Write("Removed (6): ");
            PrintLL(LL);

            Console.Write("Linked List: ");
            PrintLL(LL2);
            LL2.Remove(1);
            Console.Write("Removed (1): ");
            PrintLL(LL2);

            Console.Write("Linked List: ");
            PrintLL(LL3);
            LL3.Remove(7);
            Console.Write("Removed (7): ");
            PrintLL(LL3);
        }
        static void PrintLL(LinkedList LL)
        {
            
            Node? temp = LL.GetHead();

            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Result();
        }
    }
}
