package co.d3s.enl.wolfbox.sites;

public abstract class SiteEntry {
	
	public SiteEntry()
	{
		
	}
	
	abstract public String getAuthor();
	abstract public String getPreviewURL();
	abstract public String getImageURL();
	abstract public String getCreationTime();
	abstract public String getLink();
	abstract public String getId();
	abstract public String getTags();

}