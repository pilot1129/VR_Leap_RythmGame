using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccurancyPanel : MonoBehaviour {

    public Text Accurancy;
	
	// Update is called once per frame
	void Update () {
        float CalNum = PlayData.PlayResult.accuracy * 100;

        Accurancy.text = ((int)CalNum).ToString() + "%";
	}
}
