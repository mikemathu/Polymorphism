using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class GoogleSearch : SearchEngine
    {

        public override string[] Search(string findThis)
        {
            // Google Search is, of course, way better than 3 hard-coded results like this...
            return new string[] {
                "Here are some great results.",
                   "Aren't they neat?",
                "I found 1.2 billion things, but you will only look at the first 10." 
            };

            
        
        }

    }
}
