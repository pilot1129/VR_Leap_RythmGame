using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxComboPanel : MonoBehaviour {

    public Text Combo;

    // Update is called once per frame
    void Update()
    {
        Combo.text = PlayData.PlayResult.maxCombo.ToString();
    }
}