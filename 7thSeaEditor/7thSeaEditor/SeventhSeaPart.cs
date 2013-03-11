﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thSeaEditor
{
    class SeventhSeaPart
    {
        int id;
        string name;
        string description;

        public SeventhSeaPart(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public string GetMarkdown()
        {
            return "<strong>" + name + ":</strong>" + description;
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
    }
}
