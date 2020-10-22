using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerfectPanel : MonoBehaviour {

    public Text perfect;

    // Update is called once per frame
    void Update()
    {
        perfect.text = PlayData.PlayResult.perfect.ToString();
    }
}
