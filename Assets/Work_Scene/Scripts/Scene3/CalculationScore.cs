using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculationScore :MonoBehaviour
{
    public  Sprite F;
    public  Sprite S;
    public  Sprite A;
    public  Sprite B;
    public  Sprite C;

    public  Image Music_Score01;
    public  Image Music_Score02;
    public  Image Music_Score03;

    public Text ScoreText;

    public void Update()
    {
        ChangeImage();
    }
    public  void ChangeImage()
    {
        if (PlayData.musicTitle == "Fade")
        {
            SelectGrade(Music_Score01);
        }
        else if (PlayData.musicTitle == "My Heart")
        {
            SelectGrade(Music_Score02);
        }
        else if (PlayData.musicTitle == "Time Leap")
        {
            SelectGrade(Music_Score03);
        }

    }

    public void SelectGrade(Image change)
    {
        if (PlayData.PlayResult.health > 0 && PlayData.PlayResult.accuracy > 0.9)
        {
            change.sprite = S;
        }
        else if (PlayData.PlayResult.health > 0 && PlayData.PlayResult.accuracy > 0.85)
        {
            change.sprite = A;
        }
        else if (PlayData.PlayResult.health > 0 && PlayData.PlayResult.accuracy > 0.65)
        {
            change.sprite = B;
        }
        else if (PlayData.PlayResult.health > 0 && PlayData.PlayResult.accuracy > 0.40)
        {
            change.sprite = C;
        }
        else
        {
            change.sprite = F;
        }
        ScoreText.text = PlayData.High_score.ToString();

    }

}
