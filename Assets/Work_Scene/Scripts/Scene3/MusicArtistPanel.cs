using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicArtistPanel : MonoBehaviour {
    public Text artist;
	
	// Update is called once per frame
	void Update () {
        artist.text = PlayData.Artist;
	}
}
