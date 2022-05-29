﻿using System;
namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            linkedList.AddNode(node1);
            linkedList.AddNode(node2);
            linkedList.AddNode(node3);

            linkedList.Display();

            Node node4 = new Node(80);
            linkedList.AppendNode(node4);
            linkedList.Display();

        }
    }
}