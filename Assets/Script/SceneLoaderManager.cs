using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaderManager : MonoBehaviour
{
    private static string sceneToLoad;

    public static string SceneToLoad { get => sceneToLoad; }

    //load
    public static void Load(string sceneName)
    {
        SceneLoader.Load(sceneName);
    }

    //progressload
    public static void ProgressLoad(string sceneName)
    {
        SceneLoader.ProgressLoad(sceneName);
    }

    //Reload level
    public static void ReloadLevel()
    {
        SceneLoader.ReloadLevel();
    }

    //Load Next level
    public static void LoadNextLevel()
    {
        SceneLoader.LoadNextLevel();
    }
}
