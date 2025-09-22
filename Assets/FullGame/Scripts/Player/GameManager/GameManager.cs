using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int totalScore;
    public int TotalScore { get { return totalScore; } }

    [SerializeField]
    private GameObject pauseMenuReference;
    private bool isPauseObjectActive = false;
    
    private void Awake()
    {
        if(Instance == null)
            Instance = this;

        PlayerPrefs.SetInt("PlayerScore", 0);
    }
    
    public void AddScore()
    {
        totalScore++;
        scoreText.text = "Score: " + totalScore;
    }

    private void SavePlayerScore()
    {

    }

    public void PauseMenu()
    {
        pauseMenuReference.SetActive(true);
    }

    public void StopPauseMenu()
    {

        pauseMenuReference.SetActive(false);
        
    }

    public void MainMenu()
    {

        PlayerPrefs.SetInt("PlayerScore", totalScore);
        SceneManager.LoadScene(0);
    }
}
