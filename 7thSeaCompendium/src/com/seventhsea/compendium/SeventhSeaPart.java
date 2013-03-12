package com.seventhsea.compendium;

public class SeventhSeaPart {
	private int id;
	private String name;
	private String description;
	
	public SeventhSeaPart(int id, String name, String description){
		this.id = id;
		this.name = name;
		this.description = description;
	}
	
	public int getId(){
		return id;
	}
	
	public String getName(){
		return name;
	}
	
	public String getDescription(){
		return description;
	}
	
	public String getMarkup(){
        if (description.length() == 0)
            return "<h3>" + name + "</h3>";
        else if (name.length() == 0)
            return description;
        else
            return "<strong>" + name + ":</strong>" + description;
	}
}
