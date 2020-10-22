using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour {

    public Text Score;

	// Update is called once per frame
	void Update () {
        Score.text = PlayData.PlayResult.cur_score.ToString();
	}
}
