using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicNamePanel : MonoBehaviour {
    public Text musicName;
	
	// Update is called once per frame
	void Update () {
        musicName.text = PlayData.musicTitle;
	}
}
