using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolume : MonoBehaviour {

    public void DownVolume()
    {
        if(Demo.audios.volume > 0.1f)
        Demo.audios.volume -= 0.1f;
    }

    public void UpVolume()
    {
        if(Demo.audios.volume < 0.9f)
        Demo.audios.volume += 0.1f;
    }
}
