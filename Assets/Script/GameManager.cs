using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameoOverPanel;
    [SerializeField] TMP_Text gameOverText;

    [SerializeField] PlayerController player;

    [SerializeField] Hole hole;

    private void Start()
    {
        //gameoOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (hole.Entered && gameoOverPanel.activeInHierarchy == false)
        {
            gameoOverPanel.SetActive(true);
            gameOverText.text = "Shoot Count: " + player.ShootCount;
        } 
    }

    public void BackToMainMenu()
    {
        SceneLoader.Load("MainMenu");
    }

    public void Replay()
    {
        SceneLoader.ReloadLevel();
    }

    public void PlayNext()
    {
        SceneLoader.LoadNextLevel();
    }
}
