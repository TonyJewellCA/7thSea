package com.seventhsea.compendium;

import java.util.Map;
import java.util.TreeMap;

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
		
		Cursor cursor = m_database.query("information", new String[]{"_id", "name"},"category_id = " + Integer.toString(categoryId), null, null, null, null);
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
	
	void open(){
		if (m_database == null)
			m_database = SQLiteDatabase.openDatabase(Compendium.databaseDir + Compendium.databaseName, null, SQLiteDatabase.OPEN_READONLY);
	}
}
