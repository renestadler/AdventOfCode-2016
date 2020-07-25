using Days.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day13
    {
        private static bool isValid(int row, int col)
        {
            return (row >= 0) && (row < 500) &&
                   (col >= 0) && (col < 500);
        }

        private static int[] rowNum = { -1, 0, 0, 1 };
        private static int[] colNum = { 0, -1, 1, 0 };

        public static int PartOne(int input)
        {
            int[,] ar = new int[500, 500];
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    int num = i * i + 3 * i + 2 * i * j + j + j * j + input;
                    string binaryNumberString = Convert.ToString(num, 2);
                    ar[i, j] = binaryNumberString.Sum(a => a == '1' ? 1 : 0) % 2 == 0 ? 1 : 0;
                }
            }

            Point src = new Point { X = 1, Y = 1 };
            Point dest = new Point { X = 31, Y = 39 };
            if (ar[src.X, src.Y] != 1 ||
                ar[dest.X, dest.Y] != 1)
                return -1;

            bool[,] visited = new bool[500, 500];

            visited[src.X, src.Y] = true;

            Queue<QueueNode> q = new Queue<QueueNode>();

            QueueNode s = new QueueNode(src, 0);
            q.Enqueue(s);

            while (q.Count != 0)
            {
                QueueNode curr = q.Peek();
                Point pt = curr.pt;

                if (pt.X == dest.X && pt.Y == dest.Y)
                    return curr.dist;

                q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int row = (int)(pt.X + rowNum[i]);
                    int col = (int)(pt.Y + colNum[i]);

                    if (isValid(row, col) &&
                            ar[row, col] == 1 &&
                       !visited[row, col])
                    {
                        visited[row, col] = true;
                        QueueNode Adjcell = new QueueNode(new Point { X = row, Y = col },
                                                              curr.dist + 1);
                        q.Enqueue(Adjcell);
                    }
                }
            }
            return -1;
        }

        public static int PartTwo(int input)
        {
            int[,] ar = new int[500, 500];
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    int num = i * i + 3 * i + 2 * i * j + j + j * j + input;
                    string binaryNumberString = Convert.ToString(num, 2);
                    ar[i, j] = binaryNumberString.Sum(a => a == '1' ? 1 : 0) % 2 == 0 ? 1 : 0;
                }
            }

            Point src = new Point { X = 1, Y = 1 };
            Point dest = new Point { X = 31, Y = 39 };
            if (ar[src.X, src.Y] != 1 ||
                ar[dest.X, dest.Y] != 1)
                return -1;

            bool[,] visited = new bool[100, 100];

            visited[src.X, src.Y] = true;

            Queue<QueueNode> q = new Queue<QueueNode>();

            QueueNode s = new QueueNode(src, 0);
            q.Enqueue(s);

            while (q.Count != 0)
            {
                QueueNode curr = q.Peek();
                Point pt = curr.pt;

                q.Dequeue();
                if (curr.dist == 50)
                {
                    continue;
                }

                for (int i = 0; i < 4; i++)
                {
                    int row = (int)(pt.X + rowNum[i]);
                    int col = (int)(pt.Y + colNum[i]);

                    if (isValid(row, col) &&
                            ar[row, col] == 1 &&
                       !visited[row, col])
                    {
                        visited[row, col] = true;
                        QueueNode Adjcell = new QueueNode(new Point { X = row, Y = col },
                                                              curr.dist + 1);
                        q.Enqueue(Adjcell);
                    }
                }
            }
            var sum = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (visited[i, j])
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
    }
}

