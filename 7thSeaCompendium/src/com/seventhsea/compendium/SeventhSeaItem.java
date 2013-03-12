package com.seventhsea.compendium;

import java.util.List;

public class SeventhSeaItem {
	int id;
	String name;
	String description;
	List<SeventhSeaPart> parts;
	
	public SeventhSeaItem(int id, String name, String description, List<SeventhSeaPart> parts){
		this.id = id;
		this.name = name;
		this.description = description;
		this.parts = parts;
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
	
	public List<SeventhSeaPart> getParts(){
		return parts;
	}
	
	public String getMarkup(){
        String markdown = "";
        
        if (description.length() > 0)
        	markdown = markdown.concat("<p>" + description + "</p>");

        for (SeventhSeaPart part : parts)
            markdown += "<p>" + part.getMarkup() + "</p>";
        
        return markdown;
	}
}
