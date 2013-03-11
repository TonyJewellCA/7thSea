using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thSeaEditor
{
    class ListItemWithId
    {
        private string text;
        private int id;

        public ListItemWithId(string text, int id)
        {
            this.text = text;
            this.id = id;
        }

        public string Text
        {
            get { return text; }
        }

        public int Id
        {
            get { return id; }
        }

        public override string ToString()
        {
            return text;
        }
    }
}
