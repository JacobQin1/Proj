using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class Repository : IReposity
    {
        //public void Add(Stack i, char o, int p,int level)
        //{
        //    if (o == '{')
        //    {
        //        i.Push('{');
        //        level = level + 1;

        //    }

        //    if( o == '}')
        //    {
        //        p = p + level;
        //        i.Pop();
        //        level = level - 1;
        //    }

        //}
        public int Add(string id, int score, int level)
        {

            Stack<char> qw = new Stack<char>();
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == '{')
                {
                    qw.Push('{');
                    level++;
                    continue;
                }
                else if (id[i] == '}')
                {
                    
                    score = score + level;
                    if (qw.Count == 0)
                    {
                        continue;
                    }
                    qw.Pop();
                    level--;
                    continue;
                }
                else if (id[i] == '!')
                {
                    if (i <= id.Length - 2)
                    {
                        return score;
                    }
                    i++;
                    continue;
                }
                else if (id[i] == '<')
                {
                    i++;
                   i= Garbage(id, i, id.Length);
                }
                else
                {
                    continue;
                }
            }
            return score;
        }

        public int Garbage(string id, int current, int len)
        {
            while (id[current] != '>' && current <= len - 1)
            {
                if (id[current] == '!')
                {
                    current = current + 2;
                    continue;
                }

                current++;



            }

            if (id[current] == '>' && current <= len - 1)
            {
                //current++;
                return current;
            }
            if (current > len - 1)
            {
                return -1;
            }

            return -2;
        }
    }
  
    public interface IReposity:Irepo
    {
        // int Add(string id, int score, int level);

        //int Garbage(string id, int current, int len);
        int Add(string id, int scroe, int level);
        int Garbage(string id, int current, int len);
    }
}
