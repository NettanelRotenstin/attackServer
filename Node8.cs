using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Node8
    {
        private int _age;
        private List<string> _names;

        public Node8(string s, int i) 
        {
            _age = i;
            _names.Add(s);
        }
        public int GetAge()
        {
            return this._age;
        }
        public List<string> GetNames()
        {
            return this._names;
        }
    }
}
