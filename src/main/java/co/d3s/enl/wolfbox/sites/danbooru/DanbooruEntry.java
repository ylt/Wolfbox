package co.d3s.enl.wolfbox.sites.danbooru;

import java.util.Date;

import co.d3s.enl.wolfbox.sites.booru.BooruEntry;
import net.sf.json.JSONObject;

public class DanbooruEntry extends BooruEntry {
	private Danbooru bsite;
	private JSONObject image;
	
	public DanbooruEntry(Danbooru site, JSONObject image) {
		this.site = this.bsite = site;
        this.image = image;
	}

	@Override
	public String getAuthor() {
		return image.getString("uploader_name");
	}

	@Override
	public String getPreviewURL() {
		return bsite.siteURL + image.getString("preview_file_url");
	}

	@Override
	public String getImageURL() {
		return bsite.siteURL + image.getString("file_url");
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
		return image.getString("tag_string");
	}

}
