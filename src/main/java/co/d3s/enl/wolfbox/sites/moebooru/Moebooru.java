package co.d3s.enl.wolfbox.sites.moebooru;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.LinkedList;
import java.util.List;

import net.sf.json.JSONArray;
import net.sf.json.JSONException;
import net.sf.json.JSONObject;
import co.d3s.enl.wolfbox.sites.SiteEntry;
import co.d3s.enl.wolfbox.sites.booru.Booru;

public class Moebooru extends Booru {
	public String siteURL;
	private String search;
	
	private List<SiteEntry> entries;
	
	public Moebooru(String siteURL, String search) {
		this.siteURL = siteURL;
		this.search = search;
		entries = new LinkedList<SiteEntry>();
		try {
			String data = downloadData(new URL(siteURL + "/post.json?" + search));
			
			JSONArray jdata = JSONArray.fromObject(data);
			
			for (Object nodeo : jdata) {
				JSONObject node = (JSONObject)nodeo;
				
				MoebooruEntry entry = new MoebooruEntry(this, node);
				entries.add(entry);
			}
		}
		catch (MalformedURLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	@Override
	public List<SiteEntry> getPosts() {
		return entries;
	}
}
