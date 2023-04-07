namespace MyStackLibrary;
public unsafe class MyStack
{

    private int size;
    private Node* head;

    public MyStack(int size = 5)
    {
        this.size = size;
    }

    public void push(int value)
    {
        Node newNode = new Node();
        newNode.value = value;
        if (head == null)
        {
            this.head = &newNode;
            return;
        }
        Node* temp = this.head;
        this.head = &newNode;
        this.head->value = value;
        this.head->next = temp;
    }

    public void printStack()
    {
        string stackString = "";
        Node* current = this.head;
        while (current != null)
        {
            stackString += current->value.ToString() + ' ';
            current = current->next;
        }
        stackString = stackString.Trim();
        Console.WriteLine(stackString);
    }

    public void changeFirstAndLast()
    {
        Node* first = this.head;
        Node* last = this.head;
        while (true)
        {
            if (last->next->next != null)
            {
                last = last->next;
            } else
            {
                break;
            }
        }
        last->next->next = first->next;
        first->next = null;
        last->next = first;
        this.head = last;
    }
}

