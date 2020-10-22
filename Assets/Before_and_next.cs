using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Before_and_next : MonoBehaviour
{

    public GameObject music01;
    public Text Name01;
    public Text Artist01;
    public Image Image01;
    public Text Difficulty01;
    public Image MusicScore01;

    public GameObject music02;
    public Text Name02;
    public Text Artist02;
    public Image Image02;
    public Text Difficulty02;
    public Image MusicScore02;

    public GameObject music03;
    public Text Name03;
    public Text Artist03;
    public Image Image03;
    public Text Difficulty03;
    public Image MusicScore03;

    public GameObject music04;
    public Text Name04;
    public Text Artist04;
    public Image Image04;
    public Text Difficulty04;
    public Image MusicScore04;

    public GameObject music05;
    public Text Name05;
    public Text Artist05;
    public Image Image05;
    public Text Difficulty05;
    public Image MusicScore05;

    public void PressedBefore()
    {
        string EmptyName;      // 계단 역할
        string EmptyArtist;
        Sprite EmptyImage;
        string EmptyDifficulty;
        Sprite EmptyMusicScore;
        // EmptyObject = music01;

        EmptyName = Name01.text;
        EmptyArtist = Artist01.text;
        EmptyImage = Image01.sprite;
        EmptyDifficulty = Difficulty01.text;
        EmptyMusicScore = MusicScore01.sprite;

        //music01 = music02;
        Name01.text = Name02.text;
        Artist01.text = Artist02.text;
        Image01.sprite = Image02.sprite;
        Difficulty01.text = Difficulty02.text;
        MusicScore01.sprite = MusicScore02.sprite;

        //music02 = music03;
        Name02.text = Name03.text;
        Artist02.text = Artist03.text;
        Image02.sprite = Image03.sprite;
        Difficulty02.text = Difficulty03.text;
        MusicScore02.sprite = MusicScore03.sprite;


        //music03 = music04;
        Name03.text = Name04.text;
        Artist03.text = Artist04.text;
        Image03.sprite = Image04.sprite;
        Difficulty03.text = Difficulty04.text;
        MusicScore03.sprite = MusicScore04.sprite;


        //music04 = music05;
        Name04.text = Name05.text;
        Artist04.text = Artist05.text;
        Image04.sprite = Image05.sprite;
        Difficulty04.text = Difficulty05.text;
        MusicScore05.sprite = MusicScore05.sprite;


        //music05 = EmptyObject;
        Name05.text = EmptyName;
        Artist05.text = EmptyArtist;
        Image05.sprite = EmptyImage;
        Difficulty05.text = EmptyDifficulty;
        MusicScore05.sprite = EmptyMusicScore;


    }


    public void PressednNext()
    {
        string EmptyName;      // 계단 역할
        string EmptyArtist;
        Sprite EmptyImage;
        string EmptyDifficulty;
        Sprite EmptyMusicScore;
        // EmptyObject = music01;

        EmptyName = Name01.text;
        EmptyArtist = Artist01.text;
        EmptyImage = Image01.sprite;
        EmptyDifficulty = Difficulty01.text;
        EmptyMusicScore = MusicScore01.sprite;

        //music01 = music02;
        Name01.text = Name05.text;
        Artist01.text = Artist05.text;
        Image01.sprite = Image05.sprite;
        Difficulty01.text = Difficulty05.text;
        MusicScore01.sprite = MusicScore05.sprite;


        //music02 = music03;
        Name05.text = Name04.text;
        Artist05.text = Artist04.text;
        Image05.sprite = Image04.sprite;
        Difficulty05.text = Difficulty04.text;
        MusicScore05.sprite = MusicScore04.sprite;

        //music03 = music04;
        Name04.text = Name03.text;
        Artist04.text = Artist03.text;
        Image04.sprite = Image03.sprite;
        Difficulty04.text = Difficulty03.text;
        MusicScore04.sprite = MusicScore03.sprite;

        //music04 = music05;
        Name03.text = Name02.text;
        Artist03.text = Artist02.text;
        Image03.sprite = Image02.sprite;
        Difficulty03.text = Difficulty02.text;
        MusicScore03.sprite = MusicScore02.sprite;

        //music05 = EmptyObject;
        Name02.text = EmptyName;
        Artist02.text = EmptyArtist;
        Image02.sprite = EmptyImage;
        Difficulty02.text = EmptyDifficulty;
        MusicScore02.sprite = EmptyMusicScore;
    }
}
