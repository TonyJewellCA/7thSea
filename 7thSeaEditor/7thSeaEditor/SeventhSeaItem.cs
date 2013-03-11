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

        List<SeventhSeaPart> parts = new List<SeventhSeaPart>();

        public SeventhSeaItem(int id, int categoryId, string name, string description)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
            this.description = description;
        }

        private int FindPartIndex(SeventhSeaPart part)
        {
            for (int i = 0; i < parts.Count; i++)
            {
                if (parts[i].Id == part.Id)
                    return i;
            }

            return -1;
        }

        private void SwapParts(int a, int b)
        {
            SeventhSeaPart temp = parts[b];

            parts[b] = parts[a];
            parts[a] = temp;
        }

        public void AddPart(SeventhSeaPart part)
        {
            parts.Add(part);
        }

        public bool MovePartUp(SeventhSeaPart part)
        {
            int index = FindPartIndex(part);

            if (parts.Count == 1 || index <= 0)
                return false;

            SwapParts(index, index -1);

            return true;
        }

        public bool MovePartDown(SeventhSeaPart part)
        {
            int index = FindPartIndex(part);

            if (parts.Count == 1 || index == parts.Count -1)
                return false;

            SwapParts(index, index + 1);
            return true;
        }

        public bool RemovePart(SeventhSeaPart part)
        {
            int index = FindPartIndex(part);

            if (index != -1)
            {
                parts.RemoveAt(index);
                return true;
            }
            else
                return false;
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
    }
}
