using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
   public  interface Irepo
    {


        //int Add(string id, int score, int level, Stack<char> qw);

        // int Add(string id, int score, int level, Stack<char> qw);
        int Add(string id, int scroe, int level);
        int Garbage(string id, int current, int len);
    }
}
