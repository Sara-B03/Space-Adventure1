using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    int playerScore = 0;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    void Start()
    {
        playerScore = PlayerPrefs.GetInt("PlayerScore");

        scoreText.text = "Player score: " + playerScore;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);

    }

}
