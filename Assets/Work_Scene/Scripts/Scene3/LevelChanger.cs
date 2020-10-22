using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour {

    public Animator animator; // 애니메티어 선언
    private int levelToLoad;
	
	// Update is called once per frame
    /*
	void Update () {
        // 여기 부분을 수정하면 자연스럽게 다른 씬으로 넘어갈 수 있음
		if(Input.GetMouseButtonDown(0))
        {
            FadeToNextLevel();
        }
	}
*/

    public void FadeToNextLevel(Image Music_number) // 파라미터 추가
    {
        if (SceneManager.GetActiveScene().name == "Scene#2-1")
            SetInGameData.Init();

        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
        PlayData.Index = Music_number.name;      // 희주 추가
    }

    public void FadeToBeforeLevel()
    {
        if (SceneManager.GetActiveScene().name == "Scene#4-1")
            SetInGameData.Init();
        FadeToLevel(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void FadeToDoubleBeforeLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex - 2);

        PlayData.PlayResult.health = 100;
    }

    public void FadeToLevel(int levelIndex) // 해당 인덱스로 Fade
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
