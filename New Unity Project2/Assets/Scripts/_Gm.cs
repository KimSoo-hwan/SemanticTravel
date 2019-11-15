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
        Re();
    SceneManager.LoadScene("Sematic Travel");
    }

void Re()
    {
        BlockControl1.i = 0;
        BlockControl1.up = 0f;
        BlockControl2.Move2 = 0;
        BlockControl2.i = 0;
        BlockControl2.up = 0f;
        BlockControl2.temp = 0;
        BlockControl3.Move2 = 0;
        BlockControl3.i = 0;
        BlockControl3.up = 0f;
        BlockControl3.temp = 0;
        BlockControl4.Move2 = 0;
        BlockControl4.i = 0;
        BlockControl4.up = 0f;
        BlockControl4.temp = 0;
        BlockControl5.Move2 = 0;
        BlockControl5.i = 0;
        BlockControl5.up = 0f;
        BlockControl5.temp = 0;
    }

}
