using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryEventYes : MonoBehaviour
{
    public TheLevelData _level;

    public void returnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void nextScene()
    {
        Debug.Log($"scene number : {_level.currentSceneIndex }");
        SceneManager.LoadScene(_level.currentSceneIndex + 1);
    }
}