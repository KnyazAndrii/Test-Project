using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    private GameObject pauseScreenInstance;
    private GameObject _BGSound;

    private bool _isPaused = false;

    private void Start()
    {
        _BGSound = GameObject.FindGameObjectWithTag("BGSound");
    }

    public void CheckIfPaused()
    {
        if (!_isPaused)
        {
            _isPaused = true;
            pauseScreenInstance = Instantiate(Resources.Load<GameObject>("CanvasPause"));
            _BGSound.GetComponent<AudioSource>().Pause();
            Time.timeScale = 0;
        }
        else
        {
            _isPaused = false;
            Destroy(pauseScreenInstance);
            _BGSound.GetComponent<AudioSource>().Play();
            Time.timeScale = 1;
        }
    }

    public void LoadScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
        Time.timeScale = 1;
    }
}