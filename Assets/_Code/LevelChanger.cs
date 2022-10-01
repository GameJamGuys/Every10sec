using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : StaticInstance<LevelChanger>
{
    Animator anim;
    int levelToLoad;

    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        anim.SetTrigger("Fade");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

}
