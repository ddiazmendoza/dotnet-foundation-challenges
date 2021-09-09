namespace InsertNode
{
    public class Node 
        {
            public int data;
            public Node next;
            public int index;

            public Node(int i)
            {
                data = i; 
                next = null;
                index++;
            }

            public void Print() 
            {
                Console.Write("|" + data + "|->" + index);

                if (next != null) 
                {
                    next.Print();
                }
            }
            public void AddSorted(int data) 
            {
                if (next == null) 
                {
                    next = new Node(data);
                } 
                else if (data < next.data) 
                {
                    var temp = new Node(data);
                    temp.next = this.next; 
                    this.next = temp;
                }
                else
                {
                    next.AddSorted(data);
                }
            }
            public void AddToEnd(int data) 
            {
                if (next == null) 
                {
                    next = new Node(data);
                }
                else 
                {
                    next.AddToEnd(data);
                }
            }
        }
        public class LinkedList 
        {
            public Node headNode;

            public LinkedList()
            {
                headNode = null;
            }
            public void AddToBeginning(int data) 
            {
                if (headNode == null) 
                {
                    headNode = new Node(data);
                }
                else 
                {
                    Node temp = new Node(data);
                    temp.next = headNode;
                    headNode = temp;
                }
            }
            public void AddToEnd(int data) 
            {
                if (headNode == null) 
                {
                    headNode = new Node(data);
                }
                else  
                {
                    headNode.AddToEnd(data);
                }
            } 
            public void AddSorted(int data) 
            {
                if (headNode == null) 
                {
                    headNode = new Node(data);
                }
                else if (data < headNode.data)
                {
                    var temp = new Node(data);
                    temp.next = headNode;
                    headNode = temp;
                }
                else
                {
                    headNode.AddSorted(data);
                }
            }
            public void InsertNode(int data, int position) 
            {
                if (headNode == null) 
                {
                    headNode = new Node(data);
                }
                for (var i = 0; i < position - 1 ; i++)
                {
                    
                }
                
            }
            public void Print() 
            {
                if (headNode != null) 
                {
                    headNode.Print();
                }
            }
            
        }
    }