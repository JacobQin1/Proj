using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
namespace service
{
    
    public class TestService: ITesto
    {
        private readonly IReposity _reposity;
        public TestService (IReposity Reposity)
        {
            _reposity = Reposity;
        }

        public int ADD(string id, int score, int level)
        {
            return _reposity.Add(id, score, level);
        }

        public int Garbage(string id, int current, int len)
        {
            return _reposity.Garbage(id, current, len);
        }
    }
   
    public interface ITesto
    {
        //int ADD(string hold,string str, int newforcount,Stack<char> st, int score, int level);
        int ADD(string id, int score, int level);
        int Garbage(string id, int current, int len);
    }
}
