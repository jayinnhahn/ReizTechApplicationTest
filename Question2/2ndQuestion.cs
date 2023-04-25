
using System;
using System.Collections.Generic;

namespace BranchStructure
{
    class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }
    }

    class Program
    {
        static int CalculateDepth(Branch branch)
        {
            int maxDepth = 0;
            foreach (Branch b in branch.branches)
            {
                int depth = CalculateDepth(b);
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }
            return maxDepth + 1;
        }

        static void Main(string[] args)
        {
            // Create the hierarchical structure
            Branch root = new Branch();
            for (int i = 0; i < 2; i++)
            {
                Branch branch1 = new Branch();
                for (int j = 0; j < 2; j++)
                {
                    Branch branch2 = new Branch();
                    for (int k = 0; k < 2; k++)
                    {
                        Branch branch3 = new Branch();
                        branch2.branches.Add(branch3);
                    }
                    branch1.branches.Add(branch2);
                }
                root.branches.Add(branch1);
            }

            int depth = CalculateDepth(root);
            Console.WriteLine($"The depth of the structure is {depth}");
        }
    }
}