using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_Canvas_UI : MonoBehaviour {

    public Image BannerImage;
    public Text m_Name;
    public Text m_Artist;
    public Image ScoreImage;
   

    public void Call_Update(Image BI, string IT, string NT,Sprite SI)
    {
        BannerImage.sprite = BI.sprite;
        m_Name.text = IT;
        m_Artist.text = NT;
        ScoreImage.sprite = SI;
    }
}
