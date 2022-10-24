using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameManager gm;

    [SerializeField] private GameObject pauseMenu;
    
    [SerializeField] private GameObject endMenu;
    void Update()
    {
        if(gm) {
            if (gm.isPaused)
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
            } else if (gm.isEnded)
            {
                Time.timeScale = 0f;
                endMenu.SetActive(true);
            }
        }
    }
    
    public void unPause()
    {
        gm.isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
