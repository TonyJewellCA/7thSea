package com.seventhsea.compendium;

import java.io.File;

import com.example.compendium.R;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.database.Cursor;
import android.support.v4.widget.SimpleCursorAdapter;
import android.view.Menu;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListView;
import android.widget.Toast;

public class MainActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        createApplicationFoldersIfNecessary();
        installDatabaseIfNecessary();
        initListView();
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.activity_main, menu);
        
        return true;
    }
    
    private void initListView(){
    	CompendiumDatabase database =  new CompendiumDatabase();
    	database.open();
    	
    	String[] from = new String[]{"name"};
    	int[] to = new int[]{R.id.item_name};
    	SimpleCursorAdapter adapter = new SimpleCursorAdapter(getApplicationContext(), R.layout.list_item, database.getCategories(), from, to, 0);
    	
    	ListView listView = (ListView)findViewById(R.id.category_view);
    	
    	listView.setAdapter(adapter);
    	
    	listView.setOnItemClickListener(new OnItemClickListener() {
    		   @Override
    		   public void onItemClick(AdapterView<?> listView, View view, int position, long id) {
	    		   Cursor cursor = (Cursor) listView.getItemAtPosition(position);
	    		   
	    		   int categoryId = cursor.getInt(cursor.getColumnIndex("_id"));
	    		   String categoryName = cursor.getString(cursor.getColumnIndex("name"));
	    		   
	    		   startCategoryViewActivity(categoryId, categoryName);
    		   }
    		  });
    	
    }
    
	
	private void installDatabaseIfNecessary(){
		//for now this will always copy...eventually only copy if db is updated
		
		CompendiumUtils.copyAssetToFile(getApplicationContext(), 
						Compendium.databaseName, 
						Compendium.databaseDir + Compendium.databaseName);
	}
	
	private void createApplicationFoldersIfNecessary(){
		 File databaseDir = new File(Compendium.databaseDir);
		 if (!databaseDir.exists())
			 databaseDir.mkdir();
	 }
	
	private void startCategoryViewActivity(int categoryId, String categoryName){
		Intent intent = new Intent(this, CategoryViewActivity.class);
		intent.putExtra(Compendium.extraItemId, categoryId);
		intent.putExtra(Compendium.extraItemName, categoryName);
		startActivity(intent);
	}
}
