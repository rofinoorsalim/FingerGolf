using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    private static string sceneToLoad;

    public static string SceneToLoad { get => sceneToLoad; }

    //load
    public static void Load(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //progressload
    public static void ProgressLoad(string sceneName)
    {
        sceneToLoad = sceneName;
        Debug.Log("progresload");
        SceneManager.LoadScene("LoadingProgress");
    }

    //Reload level
    public static void ReloadLevel()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        ProgressLoad(currentScene);
    }

    //Load Next level
    public static void LoadNextLevel()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        //int nextLevel = int.Parse(currentSceneName.Split("Level")[1]) + 1;
        int nextLevel = int.Parse(currentSceneName.Split('L')[1]) + 1;
        string nextSceneName = "L" + nextLevel;

        if (SceneUtility.GetBuildIndexByScenePath(nextSceneName)== -1)
        {
            Debug.LogError(nextSceneName + " Does not exist");
            return;
        }
        ProgressLoad(nextSceneName);    }
}
