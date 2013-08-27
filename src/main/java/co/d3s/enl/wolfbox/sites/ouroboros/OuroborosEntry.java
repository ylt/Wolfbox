package co.d3s.enl.wolfbox.sites.ouroboros;

import java.util.Date;

import net.sf.json.JSONObject;
import co.d3s.enl.wolfbox.sites.booru.BooruEntry;

public class OuroborosEntry extends BooruEntry {
	private Ouroboros bsite;
	private JSONObject image;
	
	public OuroborosEntry(Ouroboros site, JSONObject image) {
		this.site = this.bsite = site;
        this.image = image;
	}

	@Override
	public String getAuthor() {
		return image.getString("author");
	}

	@Override
	public String getPreviewURL() {
		return image.getString("preview_url");
	}

	@Override
	public String getImageURL() {
		return image.getString("file_url");
	}

	@Override
	public Date getCreationTime() {
		return null;
	}

	@Override
	public String getLink() {
		return this.bsite.siteURL + "/post/show/" + image.getString("id") + "/";
	}

	@Override
	public int getId() {
		return image.getInt("id");
	}

	@Override
	public String getTags() {
		return image.getString("tags");
	}

}
