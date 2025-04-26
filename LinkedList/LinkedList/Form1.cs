using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LinkedListApp
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void Append(Node newNode)
        {
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Insert(Node newNode, int index)
        {
            if (index == 0)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node current = Head;
                for (int i = 0; i < index - 1 && current != null; i++)
                {
                    current = current.Next;
                }
                if (current != null)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }

        public int Delete(int index)
        {
            if (Head == null) return -1;

            if (index == 0)
            {
                int deletedValue = Head.Data;
                Head = Head.Next;
                return deletedValue;
            }

            Node current = Head;
            Node previous = null;

            for (int i = 0; i < index && current != null; i++)
            {
                previous = current;
                current = current.Next;
            }

            if (current != null)
            {
                int deletedValue = current.Data;
                previous.Next = current.Next;
                return deletedValue;
            }

            return -1;
        }

        public List<int> GetAllData()
        {
            List<int> list = new List<int>();
            Node current = Head;
            while (current != null)
            {
                list.Add(current.Data);
                current = current.Next;
            }
            return list;
        }
    }

    public partial class Form1 : Form
    {
        LinkedList linkedList = new LinkedList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int data))
            {
                int index = (int)numIndex.Value;
                Node newNode = new Node(data);
                linkedList.Insert(newNode, index);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = (int)numIndex.Value;
            linkedList.Delete(index);
            RefreshList();
        }

        private void RefreshList()
        {
            listBox1.Items.Clear();
            foreach (int data in linkedList.GetAllData())
            {
                listBox1.Items.Add(data);
            }
        }
    }
}
