﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreatPanel : MonoBehaviour {

    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = PlayData.PlayResult.great.ToString();
    }
}
