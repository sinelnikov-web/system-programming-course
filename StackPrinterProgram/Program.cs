using System.Globalization;
using MyStackLibrary;

namespace StackPrinterProgram;
class Program
{
    static unsafe void Main()
    {
        Random rand = new Random();

        Node headNode = new Node();
        Node* headPointer = &headNode;
        Node* nodePointer = headPointer;
        nodePointer->value = rand.Next(0, 101);
        nodePointer->next = null;
        Node* tempPointer;

        for (int i = 0; i < 20; i++)
        {
            Node* node = stackalloc Node[1];
            tempPointer = &node[0];
            tempPointer->value = rand.Next(0, 101);
            nodePointer->next = tempPointer;
            nodePointer = tempPointer;
        }

        
        while (true)
        {
            Console.WriteLine("1 - Напечатать стек");
            Console.WriteLine("2 - Поменять местами первый и последний элементы");
            Console.WriteLine("3 - Завершить программу");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    {
                        Node* currentPointer = headPointer;
                        while (currentPointer != null)
                        {
                            Console.Write(currentPointer->value.ToString() + " ");
                            currentPointer = currentPointer->next;
                        }
                        Console.WriteLine();
                        break;
                    }
                case "2":
                    {
                        Node* currentPointer = headPointer;
                        while (currentPointer->next->next != null)
                        {
                            currentPointer = currentPointer->next;
                        }
                        Node* tmp = currentPointer->next;
                        currentPointer->next = headPointer;
                        tmp->next = headPointer->next;
                        headPointer->next = null;
                        headPointer = tmp;
                        break;
                    }
                case "3":
                    {
                        return;
                    }
            }

        }
    }
}