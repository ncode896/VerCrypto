using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VerCrypto
{
    class CryptoList
    {
        private class Node
        {
            public int item { get; private set; }
            public char letter { get; private set; }
            public Node next { get; set; }
            public Node(int a, char ch, Node n)
            {
                item = a;
                letter = ch;
                next = n;
            }
        }

        public int count;
        Node root;
        Node last;

        public CryptoList()
        {
            count = 0;
            root = null;
            last = null;
            for (char c='a'; c<='z'; c++)
            {
                this.Add(0, c);
            }
        }

        private void Add (int item, char ch)
        {
            Node newItem = new Node(item, ch, null);
            if (last==null)
            {
                root = newItem;
            }
            else
            {
                last.next = newItem;
            }
            last = newItem;
            count++;
        }

        private int find(char c)
        {
            Node current = root;
            while(current!=null)
            {
                if (current.letter == c) return current.item;
                else current = current.next;
            }
            return -1;
        }

        public int this[char i]
        {
            get
            {
                return find(i);
            }
            set
            {
                array[i] = value;
            }
        }
       
        public void Fill(string str)
        {
            StreamReader sr = new StreamReader(str);
         
        }
    }
}
