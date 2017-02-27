using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagit_sharp
{
    public class BagException : Exception
    {
        public BagException()
        {
        }

        public BagException(string message)
        : base(message)
    {
        }

        public BagException(string message, Exception inner)
        : base(message, inner)
        {
        }

    }


    
}
