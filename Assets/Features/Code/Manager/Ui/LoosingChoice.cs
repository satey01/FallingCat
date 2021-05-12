using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoosingChoice : MonoBehaviour
{
    public TheLevelData _level;

    private void Start()
    {
    }

    public void RestartLvl()
    {
        SceneManager.LoadScene(_level.currentSceneIndex);
    }

    public void Gomenu()
    {
        SceneManager.LoadScene(0);
    }
}