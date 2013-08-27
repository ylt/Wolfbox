package co.d3s.enl.wolfbox;

import co.d3s.enl.wolfbox.sites.Site;
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
    }
}
