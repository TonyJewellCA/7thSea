package com.seventhsea.compendium;

public class SeventhSeaCategory {
	private int id;
	private String name;
	
	public SeventhSeaCategory(int id, String name){
		this.id = id;
		this.name = name;
	}
	
	public int getId(){
		return id;
	}
	
	public String getName(){
		return name;
	}
}
