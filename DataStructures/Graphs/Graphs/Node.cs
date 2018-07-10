using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node
    {
        public int Value { get; set; }

        public List<Node> Edges { get; set; }

        public bool Visited { get; set; } = false;

        public Node(int value)
        {
            Value = value;
            Edges = new List<Node>();
        }
    }
}