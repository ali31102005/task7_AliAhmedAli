using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Ahmed_Ali_7
{
    internal class MYFile : IReadable, IWritable
    {

        string s;
        public void Write()
        {
            s = Console.ReadLine();
        }

        public void Read() 
        {
            Console.WriteLine(s);
        }
    }
}
