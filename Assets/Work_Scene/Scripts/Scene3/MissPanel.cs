using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissPanel : MonoBehaviour {

    public Text miss;	
	// Update is called once per frame
	void Update () {
        miss.text = PlayData.PlayResult.miss.ToString();
	}
}
