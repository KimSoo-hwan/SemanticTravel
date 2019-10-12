using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Gm : MonoBehaviour
{
    public bool gameovertrigger = false; //게임오버 트리거
    public bool isPlayerAlive = true;

    public GameObject gameOverText;
    public GameObject retryButton;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameovertrigger == true)
        {
            GameOver();
        }
    }


    public void KillPlayer()
    {
        isPlayerAlive = false;
        player.SetActive(false);

    }
    void GameOver()
    {
        gameOverText.SetActive(true);
        KillPlayer();
    }

    public void Restart()
    {
        gameOverText.SetActive(false);
        SceneManager.LoadScene("Sematic Travel");
    }

}
