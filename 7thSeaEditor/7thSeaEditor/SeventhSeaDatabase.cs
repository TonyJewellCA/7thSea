using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _7thSeaEditor
{
    class SeventhSeaDatabase
    {
        int idCounter = 1;

        Dictionary<int, SeventhSeaCategory> categories = new Dictionary<int, SeventhSeaCategory>();
        Dictionary<int, SeventhSeaPart> parts = new Dictionary<int, SeventhSeaPart>();
        Dictionary<int, SeventhSeaItem> items = new Dictionary<int, SeventhSeaItem>();
        
        public int CreateCategory(string name)
        {
            SeventhSeaCategory category = new SeventhSeaCategory(idCounter++, name);
            categories.Add(category.Id, category);
            return category.Id;
        }

        public bool RenameCategory(int id, string newName)
        {
            if (categories.ContainsKey(id))
            {
                categories[id].Name = newName;
                return true;
            }
            else
                return false;
        }

        public void DeleteCategory(int id)
        {
            categories.Remove(id);
        }

        public int CreatePart(string name, string description)
        {
            SeventhSeaPart part = new SeventhSeaPart(idCounter++, name, description);
            parts.Add(part.Id, part);
            return part.Id;
        }

        public bool UpdatePart(int id, string newName, string newDescription)
        {
            if (parts.ContainsKey(id))
            {
                parts[id].Name = newName;
                parts[id].Description = newDescription;
                return true;
            }
            else
                return false;
        }

        public void DeletePart(int id)
        {
            parts.Remove(id);
        }

        public int CreateItem(int categoryId, string name, string description)
        {
            SeventhSeaItem item = new SeventhSeaItem(idCounter++, categoryId, name, description);
            items.Add(item.Id, item);
            return item.Id;
        }

        public bool UpdateItem(int id, string name, string description)
        {
            SeventhSeaItem item = GetItem(id);

            if (item == null)
                return false;

            item.Name = name;
            item.Description = description;

            return true;
        }

        public void DeleteItem(int id)
        {
            items.Remove(id);
        }

        public bool AddPartToItem(int partId, int itemId)
        {
            SeventhSeaItem item = GetItem(itemId);
            SeventhSeaPart part = GetPart(partId);

            if (item == null || part == null)
                return false;

            item.AddPart(part);
            return true;
        }

        public bool RemovePartFromItem(int partId, int itemId)
        {
            SeventhSeaItem item = GetItem(itemId);
            SeventhSeaPart part = GetPart(partId);

            if (item == null || part == null)
                return false;

            return item.RemovePart(part);
        }

        public SeventhSeaPart GetPart(int id)
        {
            if (parts.ContainsKey(id))
                return parts[id];
            else
                return null;
        }

        public SeventhSeaCategory GetCategory(int id)
        {
            if (categories.ContainsKey(id))
                return categories[id];
            else
                return null;
        }

        public SeventhSeaItem GetItem(int id)
        {
            if (items.ContainsKey(id))
                return items[id];
            else
                return null;
        }

        public ListItemWithId[] GetItemListForCategory(int categoryId)
        {
            List<ListItemWithId> listItems = new List<ListItemWithId>();

            foreach (SeventhSeaItem item in items.Values)
            {
                if (item.CategoryId == categoryId)
                    listItems.Add(new ListItemWithId(item.Name, item.Id));
            }

            return listItems.ToArray();
        }

        public ListItemWithId[] GetPartListInfo()
        {
            ListItemWithId[] items = new ListItemWithId[parts.Count];

            int index = 0;
            foreach (SeventhSeaPart part in parts.Values)
            {
                items[index] = new ListItemWithId(part.Name, part.Id);
                index++;
            }
            return items;

        }

        public ListItemWithId[] GetCategoryListInfo()
        {
            ListItemWithId[] items = new ListItemWithId[parts.Count];

            int index = 0;
            foreach (SeventhSeaCategory category in categories.Values){
                items[index] = new ListItemWithId(category.Name, category.Id);
                index++;
            }

            return items;
        }
    }
}
