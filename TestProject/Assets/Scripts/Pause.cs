using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private OpenScene _openScene;

    private void Start()
    {
        _openScene = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<OpenScene>();
    }

    public void ExitFromPause()
    {
        _openScene.CheckIfPaused();
    }
}