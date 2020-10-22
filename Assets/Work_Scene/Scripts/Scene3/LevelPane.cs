using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPane : MonoBehaviour {

    public Text level;
	
	// Update is called once per frame
	void Update () {
        level.text = PlayData.Level.ToString();
	}
}
