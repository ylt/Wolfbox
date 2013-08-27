package co.d3s.enl.wolfbox.sites;

import java.util.Date;

public abstract class SiteEntry {
	
	public SiteEntry()
	{
		
	}
	
	abstract public String getAuthor();
	abstract public String getPreviewURL();
	abstract public String getImageURL();
	abstract public Date   getCreationTime();
	abstract public String getLink();
	abstract public int    getId();
	abstract public String getTags();

	private String progress;
	public String getProgress()
	{
		return progress;
	}
	
	
	public void DownloadPreview()
	{
		
	}
	
	public void DownloadImage(String filename)
	{
		
	}
}