public bool IsGraphIntegrated(List<Edge> graph)
        {
            Stack<int> stack = new Stack<int>();
            List<int> visited = new List<int>();
            bool found = false;
            stack.Push(1);
            visited.Add(1);
            while (stack.Count != 0)
            {
                int[] conn = ConnectedVertices(stack.Peek());
                found = false;
                for (int i = 0; i < conn.Length; i++)
                {
                    if (!visited.Contains(conn[i]))
                    {
                        stack.Push(conn[i]);
                        visited.Add(conn[i]);
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    stack.Pop();
                }
            }
            for (int i = 0; i < GraphSize; i++)
            {
                if (!visited.Contains(i + 1))
                {
                    return false;
                }
            }
            return true;
        }
