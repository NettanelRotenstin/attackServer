using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class HonorQeueu
    {
        //        8. Create a Class  "Honor Queue"
        //that should implement functions of a queue, but keep the following order:
        // enqueue can get a dictionary with key value pairs of name : age(string: int)
        // each element in the queue of the class: (Department, with the 2 properties (age, and list of names)
        //the output queue should look like:
        //1: Department: 30, [david, arnon]
        //2: Department: 23, [or]
        //3: Department: 21, [or, guy, shalev]
        //        dequeue - the first person in the list of the oldest department
        //if a new department is enqueued - should be in the matching place
        List<Node8> nodes = new List<Node8>();
        public void Enqeueu(Dictionary<string, int> ages)
        {
            Node8 Prev;
            if (nodes.Count == 0)
            {

                nodes.Add(new Node8(ages.Keys.First(), ages.Values.First())); 
            }
            else
            {
                for (int i = 0; i <= nodes.Count; i++)
                {
                     if (nodes[i].GetAge() == ages.Values.First())
                    {
                        nodes[i].GetNames().Add(ages.Keys.First());
                    }
                    if (nodes[i].GetAge() < ages.Values.First())
                    {
                        
                    }
                }
                
            }
        }
    }
}
