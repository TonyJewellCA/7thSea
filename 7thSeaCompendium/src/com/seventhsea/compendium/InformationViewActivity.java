package com.seventhsea.compendium;

import java.util.Map;

import com.example.compendium.R;
import com.example.compendium.R.layout;
import com.example.compendium.R.menu;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

public class InformationViewActivity extends Activity {
	
	private int m_infoId;
	private String m_infoName;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_information_view);
		
		getActionBar().setDisplayHomeAsUpEnabled(true);
			
		Intent intent = getIntent();
		m_infoId = intent.getIntExtra(Compendium.extraItemId, 0);
		m_infoName = intent.getStringExtra(Compendium.extraItemName);
		
		setTitle(m_infoName);
		
		initView();
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

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_information_view, menu);
		return true;
	}
	
	void initView(){
		CompendiumDatabase database =  new CompendiumDatabase();
		Map<String, String> info = database.GetItemInformation(m_infoId);
		
		TextView description = (TextView)findViewById(R.id.info_descriotion);
		description.setText(info.get("information"));
	}

}