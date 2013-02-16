package com.seventhsea.compendium;

import android.app.ListActivity;
import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.support.v4.widget.SimpleCursorAdapter;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListView;

import com.example.compendium.R;

public class CategoryViewActivity extends ListActivity {
	
	private String m_categoryName;
	private int m_categoryId;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		getActionBar().setDisplayHomeAsUpEnabled(true);
		
		Intent intent = getIntent();
		m_categoryId = intent.getIntExtra(Compendium.extraItemId, 0);
		m_categoryName = intent.getStringExtra(Compendium.extraItemName);
		
		setTitle(m_categoryName);
		
		initListView();
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_category_view, menu);
		return true;
	}
	
	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		switch (item.getItemId()) {
		case android.R.id.home:
			finish();
			return true;
		};
		
		return false;
	}
	
    private void initListView(){
    	CompendiumDatabase database =  new CompendiumDatabase();
    	
    	String[] from = new String[]{"name"};
    	int[] to = new int[]{R.id.item_name};
    	SimpleCursorAdapter adapter = new SimpleCursorAdapter(getApplicationContext(), R.layout.list_item, database.getCategoryItems(m_categoryId), from, to, 0);
    	
    	ListView listView = getListView();
    	
    	listView.setAdapter(adapter);
    	
    	listView.setOnItemClickListener(new OnItemClickListener() {
    		   @Override
    		   public void onItemClick(AdapterView<?> listView, View view, int position, long id) {
	    		   Cursor cursor = (Cursor) listView.getItemAtPosition(position);
	    		   
	    		   int infoId = cursor.getInt(cursor.getColumnIndex("_id"));
	    		   String infoName = cursor.getString(cursor.getColumnIndex("name"));
	    		   
	    		   startInformationViewActivity(infoId, infoName);
    		   }
    		  });
    }
    
	private void startInformationViewActivity(int infoId, String infoName){
		Intent intent = new Intent(this, InformationViewActivity.class);
		intent.putExtra(Compendium.extraItemId, infoId);
		intent.putExtra(Compendium.extraItemName, infoName);
		startActivity(intent);
	}

}
