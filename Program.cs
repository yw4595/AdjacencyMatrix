using System;
/*
 * Author: Yanzhi Wang
 * Purpose: // This code defines an enum to represent colors, and creates an adjacency matrix and adjacency lists to represent a graph. The graph represents connections between colors.
// The adjacency matrix is printed out to the console, as well as the adjacency lists (including the weights of the edges)
 * Restrictions: None
 */


class Program
{
    // Define an enum to represent the colors
    enum EColor
    {
        red,
        blue,
        yellow,
        cyan,
        gray,
        purple,
        orange,
        green
    }

    static void Main(string[] args)
    {
        // Define the adjacency matrix for the graph
        int[,] colorMGraph = new[,]
        {
            /*red blue yellow cyan gray purple orange green*/
            /*red*/   {-1, 1, -1, -1, 5, -1, -1, -1 },
            /*blue*/  {-1,-1, 8,  1,-1,-1,-1,-1},
            /*yellow*/{-1,-1,-1, -1,-1,-1,-1, 6},
            /*cyan*/  {-1,-1, 1, -1, 0,-1,-1,-1},
            /*gray*/  {-1,-1,-1,  0,-1,-1, 1,-1},
            /*purple*/{-1,-1, 1, -1,-1,-1,-1,-1},
            /*orange*/{-1,-1,-1, -1,-1, 1,-1,-1},
            /*green*/ {-1,-1,-1, -1,-1,-1,-1,-1 }
        };

        // Define the adjacency list for the graph (vertices and their adjacent vertices)
        int[][] colorAGraph = new int[][]
        {
            /*red*/   new int[]{(int)EColor.blue, (int)EColor.gray},
            /*blue*/  new int[]{2, 3},
            /*yellow*/new int[]{7},
            /*cyan*/  new int[]{1, 4},
            /*gray*/  new int[]{3, 6},
            /*purple*/new int[]{2},
            /*orange*/new int[]{5},
            /*green*/ null
        };

        // Define the adjacency list for the graph (vertices and the weights of their adjacent edges)
        int[][] colorWGraph = new int[][]
        {
            /*red*/   new int[]{1, 5},
            /*blue*/  new int[]{8, 1},
            /*yellow*/new int[]{6},
            /*cyan*/  new int[]{1, 0},
            /*gray*/  new int[]{0, 1},
            /*purple*/new int[]{1},
            /*orange*/new int[]{1},
            /*green*/ null
        };

        // Print out the adjacency matrix
        Console.WriteLine("Adjacency Matrix:");
        for (int i = 0; i < colorMGraph.GetLength(0); i++)
        {
            for (int j = 0; j < colorMGraph.GetLength(1); j++)
            {
                Console.Write(colorMGraph[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Print out the adjacency list
        Console.WriteLine("\nAdjacency List:");
        for (int i = 0; i < colorAGraph.Length; i++)
        {
            Console.Write((EColor)i + ": ");
            if (colorAGraph[i] == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                for (int j = 0; j < colorAGraph[i].Length; j++)
                {
                    Console.Write((EColor)colorAGraph[i][j] + "(" + colorWGraph[i][j] + ")" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

