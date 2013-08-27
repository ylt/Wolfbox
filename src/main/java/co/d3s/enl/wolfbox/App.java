package co.d3s.enl.wolfbox;

import java.io.Console;

import co.d3s.enl.wolfbox.sites.Site;
import co.d3s.enl.wolfbox.sites.SiteEntry;
import co.d3s.enl.wolfbox.sites.danbooru.Danbooru;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        //System.out.println( "Hello World!" );
    	
    	Site site = new Danbooru("http://danbooru.donmai.us", "");
    	System.out.println(site);
    	for(SiteEntry entry : site.getPosts())
    	{
    		System.out.println(entry.getAuthor()+", "+entry.getTags());
    	}
    }
}
