using System;
using System.Collections.Generic;

Exec();

     void Exec()
    {
        int[,] adjacencyMatrix = new int[,]
        {
            { 0, 1, 0, 0, 0 },
            { 1, 0, 1, 0, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 1, 0 }
        };

        var blockMatrix = GetBlockAdjacencyMatrix(adjacencyMatrix);
        PrintMatrix(blockMatrix);
    }

     int[,] GetBlockAdjacencyMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        bool[] visited = new bool[n];
        List<List<int>> components = new List<List<int>>();


        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                List<int> component = new List<int>();
                DFS(i, matrix, visited, component);
                components.Add(component);
            }
        }

        List<int> newOrder = new List<int>();
        foreach (var comp in components)
            newOrder.AddRange(comp);

        int[,] newMatrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                newMatrix[i, j] = matrix[newOrder[i], newOrder[j]];
            }
        }

        return newMatrix;
    }

     void DFS(int v, int[,] matrix, bool[] visited, List<int> component)
    {
        visited[v] = true;
        component.Add(v);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[v, i] == 1 && !visited[i])
                DFS(i, matrix, visited, component);
        }
    }

     void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }

