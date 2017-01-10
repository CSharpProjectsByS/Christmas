using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Święta
{
    class ChangeWorldHandler
    {
        private Label label;

        Dictionary<String, String> dictionary; 

        public ChangeWorldHandler(Label label)
        {
            this.label = label;
            dictionary = new Dictionary<string, string>();
            initDictionaryValues();
        }

        private void initDictionaryValues()
        {
            dictionary.Add("Santa Claus", "Święty Mikołaj");
            dictionary.Add("Teddy Bear", "Miś");
            dictionary.Add("Christmas Tree", "Choinka");
            dictionary.Add("Reindeer", "Renifer");
            dictionary.Add("Gifts", "Prezenty");
            dictionary.Add("Snowman", "Bałwan");
        }

        public void ChangeWorld(object oSender, WordPLArg oEventArgs)
        {
            String key = oEventArgs.value;
            String value = dictionary[key];
            label.Text = value + " - " + key;    
        } 
    }
}
