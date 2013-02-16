package com.seventhsea.compendium;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

import android.content.Context;

public class CompendiumUtils {
	
	 public static void copyAssetToFile(Context context, String asset, String path){

		try{
			InputStream istream = context.getAssets().open(asset);
			OutputStream ostream = new FileOutputStream(path);
			
			byte[] buffer = new byte[1024];
			int length;

			while ((length = istream.read(buffer)) != -1){
				ostream.write(buffer, 0, length);
			}
			
			ostream.flush();
			ostream.close();
			istream.close();
			
		 }catch (IOException e){}
		}
}
