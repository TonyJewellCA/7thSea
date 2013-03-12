package com.seventhsea.compendium;

import java.util.List;
import java.util.Map;
import java.util.TreeMap;
import java.util.Vector;

import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.os.Environment;
import android.util.Log;


public class CompendiumDatabase {

	
	private SQLiteDatabase m_database = null;
	
	CompendiumDatabase(){}
	
	public Cursor getCategories(){
		open();
		
		Cursor cursor = m_database.query("categories", new String[]{"_id", "name"},null, null, null, null, null);
		cursor.moveToFirst();
		
		return cursor;
	}
	
	public Cursor getCategoryItems(int categoryId){
		open();
		
		Cursor cursor = m_database.query("items", new String[]{"_id", "name"},"categoryId = " + Integer.toString(categoryId), null, null, null, null);
		cursor.moveToFirst();
		
		return cursor;
	}
	
	public Map<String, String> GetItemInformation(int itemId){
		open();
		
		TreeMap<String, String> info = new TreeMap<String, String>();
		String[] columns = new String[]{"_id", "name", "information"};
		Cursor cursor = m_database.query("information", columns ,"_id = " + Integer.toString(itemId), null, null, null, null);
		
		if (cursor.moveToFirst()){
			for (String column : columns)
				info.put(column, cursor.getString(cursor.getColumnIndex(column)));
		}
		
		return info;
	}
	
	private List<SeventhSeaPart> getPartsForItem(int id){
		Vector<SeventhSeaPart> parts = new Vector<SeventhSeaPart>();
		String sql = "SELECT parts._id, parts.name, parts.description FROM item_parts JOIN parts ON item_parts.partId = parts._id WHERE item_parts.itemId = ?;";
		Cursor results = m_database.rawQuery(sql, new String[]{String.valueOf(id)});
		
		while(results.moveToNext())
			parts.add(new SeventhSeaPart(results.getInt(0), results.getString(1), results.getString(2)));
		
		return parts;
	}
	
	public SeventhSeaItem GetItem(int id){
		open();
		
		List<SeventhSeaPart> parts = getPartsForItem(id);
		
		String sql = "SELECT _id, name, description from parts where _id = @id";
		Cursor result = m_database.rawQuery(sql, new String[]{String.valueOf(id)});
		
		if (result.moveToFirst())
			return new SeventhSeaItem(result.getInt(0), result.getString(1), result.getString(2), parts);
		else
			return null;
	}
	
	void open(){
		if (m_database == null)
			m_database = SQLiteDatabase.openDatabase(Compendium.databaseDir + Compendium.databaseName, null, SQLiteDatabase.OPEN_READONLY);
	}
}
