using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab1
{
    public class Graph
    {
        private LinkedList<int>[] adjLists;
        private bool[] visited;
        private List<int> dist = new List<int>();

        Graph(int vertices)
        {
            adjLists = new LinkedList<int>[vertices];
            visited = new bool[vertices];

            for (int i = 0; i < vertices; i++)
                adjLists[i] = new LinkedList<int>();
        }

        private void addEdge(int src, int dest)
        {
            adjLists[src].AddLast(dest);
        }

        public void DFS(int vertex)
        {
            var sw = Stopwatch.StartNew();
            visited[vertex] = true;

            foreach (int item in adjLists[vertex])
            {
                if(!visited[item])
                {
                    DFS(item);
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
        }

        public void BFS(int vertex) {
            var sw = Stopwatch.StartNew();
            Queue<int> q = new Queue<int>();
            q.Enqueue(vertex);
            visited[vertex] = true;
            dist[vertex] = 0;

            while(!q.Any())
            {
                int v = q.Dequeue();

                foreach (int to in adjLists[v])
                {
                    if (!visited[to])
                    {
                        visited[to] = true;
                        dist[to] = dist[v] + 1;
                        q.Enqueue(to);
                    }
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
        }

    }
}
