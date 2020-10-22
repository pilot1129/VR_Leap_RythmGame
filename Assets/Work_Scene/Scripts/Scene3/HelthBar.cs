using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthBar : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (PlayData.PlayResult.health > 100)
            PlayData.PlayResult.health = 100;

        GetComponent<RectTransform>().sizeDelta = new Vector2(PlayData.PlayResult.health / 100, 0.2f);

	}
}
