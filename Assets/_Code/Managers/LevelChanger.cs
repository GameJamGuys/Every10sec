using UnityEngine;
using UnityEngine.SceneManagement;
using Kerioth.Stuff;

public class LevelChanger : StaticInstance<LevelChanger>
{
    Animator anim;
    int levelToLoad;

    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    public void Restart() => Loader.Reload();

    public void FadeToLevel(int levelIndex)
    {
        Time.timeScale = 1f;
        levelToLoad = levelIndex;
        anim.SetTrigger("Fade");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

}
