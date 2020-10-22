using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboPanel : MonoBehaviour {

    public Text Combo;
	
	// Update is called once per frame
	void Update () {
        Combo.text = PlayData.PlayResult.combo.ToString();
	}
}
