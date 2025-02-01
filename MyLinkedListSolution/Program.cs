namespace MyLinkedListSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(10);
            myLinkedList.Add(20);
            myLinkedList.Add(30);
            myLinkedList.Add(3,40);
            Console.WriteLine(myLinkedList[3]);
        }
    }
}
