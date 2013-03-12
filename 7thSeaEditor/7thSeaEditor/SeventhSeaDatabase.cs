using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace _7thSeaEditor
{
    class SeventhSeaDatabase
    {
        int idCounter = 1;

        Dictionary<int, SeventhSeaPart> parts = new Dictionary<int, SeventhSeaPart>();
        Dictionary<int, SeventhSeaItem> items = new Dictionary<int, SeventhSeaItem>();

        SQLiteConnection connection;

        public void Open(string path)
        {
            string connectionString = @"Data Source=" + path;
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }
        
        public int CreateCategory(string name)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "INSERT INTO categories VALUES (NULL, @name);";
                SQLiteCommand insert = new SQLiteCommand(sql, connection);
                insert.Parameters.Add(new SQLiteParameter("name", name));
                insert.ExecuteNonQuery();
                transaction.Commit();
            }

            SQLiteCommand rowid = new SQLiteCommand("SELECT last_insert_rowid();", connection);
            return Convert.ToInt32(rowid.ExecuteScalar());
        }

        public void RenameCategory(int id, string newName)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "UPDATE categories SET name= @newName WHERE _id = @id;";
                SQLiteCommand update = new SQLiteCommand(sql, connection);
                update.Parameters.Add(new SQLiteParameter("newName", newName));
                update.Parameters.Add(new SQLiteParameter("id", id));
                update.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void DeleteCategory(int id)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "DELETE FROM categories WHERE _id = @id;";
                SQLiteCommand del = new SQLiteCommand(sql, connection);
                del.Parameters.Add(new SQLiteParameter("id", id));
                del.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public int CreatePart(string name, string description, int categoryId)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "INSERT INTO parts VALUES (NULL, @name, @description, @categoryId);";
                SQLiteCommand insert = new SQLiteCommand(sql, connection);
                insert.Parameters.Add(new SQLiteParameter("name", name));
                insert.Parameters.Add(new SQLiteParameter("description", description));
                insert.Parameters.Add(new SQLiteParameter("categoryId", categoryId));
                insert.ExecuteNonQuery();
                transaction.Commit();
            }

            SQLiteCommand rowid = new SQLiteCommand("SELECT last_insert_rowid();", connection);
            return Convert.ToInt32(rowid.ExecuteScalar());
        }

        public void UpdatePart(int id, string name, string description)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "UPDATE parts SET name= @name, description= @description WHERE _id = @id;";
                SQLiteCommand update = new SQLiteCommand(sql, connection);
                update.Parameters.Add(new SQLiteParameter("name", name));
                update.Parameters.Add(new SQLiteParameter("description", description));
                update.Parameters.Add(new SQLiteParameter("id", id));
                update.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void DeletePart(int id)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "DELETE FROM parts WHERE _id = @id;";
                SQLiteCommand del = new SQLiteCommand(sql, connection);
                del.Parameters.Add(new SQLiteParameter("id", id));
                del.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public int CreateItem(int categoryId, string name, string description)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "INSERT INTO items VALUES (NULL, @name, @description, @categoryId);";
                SQLiteCommand insert = new SQLiteCommand(sql, connection);
                insert.Parameters.Add(new SQLiteParameter("name", name));
                insert.Parameters.Add(new SQLiteParameter("description", description));
                insert.Parameters.Add(new SQLiteParameter("categoryId", categoryId));
                insert.ExecuteNonQuery();
                transaction.Commit();
            }

            SQLiteCommand rowid = new SQLiteCommand("SELECT last_insert_rowid();", connection);
            return Convert.ToInt32(rowid.ExecuteScalar());
        }

        public void UpdateItem(int id, string name, string description)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "UPDATE items SET name= @name description= @description WHERE _id = @id;";
                SQLiteCommand update = new SQLiteCommand(sql, connection);
                update.Parameters.Add(new SQLiteParameter("name", name));
                update.Parameters.Add(new SQLiteParameter("description", description));
                update.Parameters.Add(new SQLiteParameter("id", id));
                update.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public void DeleteItem(int id)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                DeleteItemPartsForItem(id);

                string sql = "DELETE FROM items WHERE _id = @id;";
                SQLiteCommand del = new SQLiteCommand(sql, connection);
                del.Parameters.Add(new SQLiteParameter("id", id));
                del.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public int GetPartCountForItem(int itemId)
        {
            SQLiteCommand count = new SQLiteCommand("SELECT COUNT(position) from item_parts where itemId = @itemId;", connection);
            count.Parameters.Add(new SQLiteParameter("itemId", itemId));
            object result =  count.ExecuteScalar();

            if (result is DBNull)
                return 0;
            else
                return Convert.ToInt32(result);

        }

        public int AddPartToItem(int partId, int itemId)
        {
            int position = GetPartCountForItem(itemId) + 1;

            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "INSERT INTO item_parts VALUES (NULL, @itemId, @partId, @position);";
                SQLiteCommand insert = new SQLiteCommand(sql, connection);
                insert.Parameters.Add(new SQLiteParameter("itemId", itemId));
                insert.Parameters.Add(new SQLiteParameter("partId", partId));
                insert.Parameters.Add(new SQLiteParameter("position", position));
                insert.ExecuteNonQuery();
                transaction.Commit();
            }

            SQLiteCommand rowid = new SQLiteCommand("SELECT last_insert_rowid();", connection);
            return Convert.ToInt32(rowid.ExecuteScalar());
        }

        public void RemovePartFromItem(int itemPartId)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "DELETE FROM item_parts WHERE _id = @itemPartId;";
                SQLiteCommand del = new SQLiteCommand(sql, connection);
                del.Parameters.Add(new SQLiteParameter("itemPartId", itemPartId));
                del.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public SeventhSeaPart GetPart(int id)
        {
            string sql = "SELECT _id, name, description, categoryId from parts where _id = @id";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.Add(new SQLiteParameter("id", id));
            SQLiteDataReader result = command.ExecuteReader();

            if (result.Read())
                return new SeventhSeaPart(result.GetInt32(0), result.GetString(1), result.GetString(2), result.GetInt32(3));
            else
                return null;
        }

        public SeventhSeaItem GetItem(int id)
        {
            List<SeventhSeaPart> parts = GetPartsForItem(id);

            string sql = "SELECT _id, categoryId, name, description FROM items WHERE _id = @id;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.Add(new SQLiteParameter("id", id));
            SQLiteDataReader result = command.ExecuteReader();

            if (result.Read())
                return new SeventhSeaItem(result.GetInt32(0), result.GetInt32(1), result.GetString(2), result.GetString(3), parts);
            else
                return null;

        }

        private void DeleteItemPartsForItem(int id)
        {
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                string sql = "DELETE from item_parts where itemId = @id;";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.Add(new SQLiteParameter("id", id));
                command.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        private void ReadListItemsWithId(List<ListItemWithId> items, SQLiteDataReader rows)
        {
            while (rows.Read())
                items.Add(new ListItemWithId(rows.GetString(0), rows.GetInt32(1)));
        }

        public ListItemWithId[] GetItemPartsList(int itemId)
        {
            string sql = "SELECT parts.name, item_parts._id FROM item_parts JOIN parts on item_parts.partid = parts._id WHERE item_parts.itemId = @itemId ORDER BY item_parts.position;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.Add(new SQLiteParameter("itemId", itemId));

            SQLiteDataReader rows = command.ExecuteReader();
            List<ListItemWithId> items = new List<ListItemWithId>();
            ReadListItemsWithId(items, rows);

            return items.ToArray();
        }

        public ListItemWithId[] GetItemListForCategory(int categoryId)
        {
            string sql = "SELECT name, _id FROM items WHERE categoryId = @categoryId;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.Add(new SQLiteParameter("categoryId", categoryId));

            SQLiteDataReader rows = command.ExecuteReader();
            List<ListItemWithId> items = new List<ListItemWithId>();
            ReadListItemsWithId(items, rows);

            return items.ToArray();
        }

        public ListItemWithId[] GetPartListInfo()
        {
            string sql = "SELECT name, _id FROM parts;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader rows = command.ExecuteReader();
            List<ListItemWithId> items = new List<ListItemWithId>();
            ReadListItemsWithId(items, rows);

            return items.ToArray();
        }

        public ListItemWithId[] GetPartListInfoForCategory(int id)
        {
            string sql = "SELECT name, _id FROM parts where categoryId = @id;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.Add(new SQLiteParameter("id", id));
            SQLiteDataReader rows = command.ExecuteReader();
            List<ListItemWithId> items = new List<ListItemWithId>();
            ReadListItemsWithId(items, rows);

            return items.ToArray();
        }

        public ListItemWithId[] GetCategoryListInfo()
        {
            string sql = "SELECT name, _id FROM categories;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader rows = command.ExecuteReader();
            List<ListItemWithId> items = new List<ListItemWithId>();
            ReadListItemsWithId(items, rows);

            return items.ToArray();
        }

        public List<SeventhSeaPart> GetPartsForItem(int itemId)
        {
            List<SeventhSeaPart> items = new List<SeventhSeaPart>();

            string sql = "SELECT parts._id, parts.name, parts.description, parts.categoryId FROM item_parts JOIN parts ON item_parts.partId = parts._id WHERE item_parts.itemId = @itemId;";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.Add(new SQLiteParameter("itemId", itemId));
            SQLiteDataReader rows = command.ExecuteReader();

            while (rows.Read())
                items.Add (new SeventhSeaPart(rows.GetInt32(0), rows.GetString(1), rows.GetString(2), rows.GetInt32(3)));

            return items;
        }
    }
}
