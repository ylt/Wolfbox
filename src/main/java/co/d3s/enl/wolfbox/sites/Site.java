package co.d3s.enl.wolfbox.sites;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;

public class Site {

	public Site()
	{
		
	}
	
	@Override
	public String toString() {
        return "Site";
    }
	
	public static String downloadData(URL url) throws IOException {
		//TODO: find better downloader solution?
		//http://docs.oracle.com/javase/tutorial/networking/urls/readingURL.html
        BufferedReader in = new BufferedReader(
        new InputStreamReader(url.openStream()));

        int count;
        char buffer[] = new char[1024];
        StringBuilder data = new StringBuilder();
        while ((count = in.read(buffer, 0, 1024)) != -1)
        	data.append(buffer, 0, count);
        	//data.append(data, 0, count);
            //System.out.println(inputLine);
        in.close();
        
        System.out.println(data);
        return data.toString();
	}
}


