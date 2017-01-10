using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Święta
{
    class ChangeWordService
    {
        public delegate void ChangeWordDelegate(object oSender, WordPLArg oEventArgs);

        public event ChangeWordDelegate ChangeWordEvent;

        public void ChooseKlickedElement(String key)
        {
            WordPLArg arg = new WordPLArg(key);

            FireEvent(arg);
        }

        public void FireEvent(WordPLArg args)
        {
            if (ChangeWordEvent != null)
            {
                ChangeWordEvent(this, args);
            }
        }

    }
}
