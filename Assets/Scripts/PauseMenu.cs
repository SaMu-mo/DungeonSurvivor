using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject panelPausa;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused) Resume();
            else Pause();
        }
    }

    public void Pause()
    {
        panelPausa.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}