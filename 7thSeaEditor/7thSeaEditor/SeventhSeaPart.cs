using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thSeaEditor
{
    class SeventhSeaPart
    {
        int id;
        int categoryId;
        string name;
        string description;

        public SeventhSeaPart(int id, string name, string description, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.categoryId = categoryId;
        }

        public string GetMarkdown()
        {
            return Markdown(name, description);
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public static string Markdown(string name, string description)
        {
            if (description == "")
                return "<h3>" + name + "</h3>";
            else if (name == "")
                return description;
            else
                return "<strong>" + name + ":</strong>" + description;
        }
    }
}
