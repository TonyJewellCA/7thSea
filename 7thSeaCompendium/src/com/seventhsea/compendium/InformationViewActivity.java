package com.seventhsea.compendium;

import java.util.Map;

import us.feras.mdv.MarkdownView;

import com.example.compendium.R;
import com.example.compendium.R.layout;
import com.example.compendium.R.menu;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.webkit.WebView;
import android.widget.TextView;

public class InformationViewActivity extends Activity {
	
	private int m_infoId;
	private String m_infoName;
	WebView m_webView;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);

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
		m_webView = new WebView(this); 
		
		CompendiumDatabase database =  new CompendiumDatabase();
		SeventhSeaItem item = database.GetItem(m_infoId);
		
		String html = "<body style='background-color:black; color:white;'>" +
				item.getMarkup() +
				"</body>";
		
		m_webView.loadData(html,"text/html", null);
		
		setContentView(m_webView);
	}

}
