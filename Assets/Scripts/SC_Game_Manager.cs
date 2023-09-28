using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using TMPro;

public class SC_Game_Manager : MonoBehaviour
{
    public GameObject startButton;
    public Player player;
    public TMP_Text gameOverCountdown;
    public float countTimer = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isDead) {
            gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
        }

        gameOverCountdown.text = "Restarting in " + (countTimer).ToString();

        if (countTimer < 0) {
            RestartGame();
        }

        

    }

        public void startGame() {
            startButton.SetActive(false);
            Time.timeScale = 1;

    }
    public void gameOver() {
        Time.timeScale = 0;
    }

    public void RestartGame() {
        EditorSceneManager.LoadScene(0);
    }


}
