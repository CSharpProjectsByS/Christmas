using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Święta
{
    class WordPLArg: EventArgs
    {

        public String value;

        public WordPLArg(String value)
        {
            this.value = value;
        }
    }
}
