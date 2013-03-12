using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thSeaEditor
{
    class SeventhSeaItem
    {
        int id;
        int categoryId;
        string name;
        string description;

        List<SeventhSeaPart> parts;

        public SeventhSeaItem(int id, int categoryId, string name, string description, List<SeventhSeaPart> parts)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
            this.description = description;
            this.parts = parts;
        }

        public string GetMarkdown()
        {
            string markdown = "<p>" + description + "</p>";

            foreach (SeventhSeaPart part in parts)
                markdown += "<p>" + part.GetMarkdown() + "</p>";
            
            return markdown;
        }

        public int Id
        {
            get { return id; }
        }

        public int CategoryId
        {
            get { return categoryId; }
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

        public List<SeventhSeaPart> Parts
        {
            get { return parts; }
        }
    }
}
