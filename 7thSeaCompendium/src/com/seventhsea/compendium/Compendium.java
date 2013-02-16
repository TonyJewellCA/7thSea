package com.seventhsea.compendium;

import android.os.Environment;

public class Compendium {
	public static String databaseDir = Environment.getExternalStorageDirectory().getPath() + '/' +"compendium7thsea/";
	public static String databaseName = "compendium.db";
	
	public static String extraItemId = "com.seventhsea.compendium.EXTRA_ID";
	public static String extraItemName = "com.seventhsea.compendium.EXTRA_NAME";
}
