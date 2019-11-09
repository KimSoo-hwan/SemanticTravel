using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowPlayGame : MonoBehaviour
{
   
   public void ChangeFirstScene()
    {
        SceneManager.LoadScene("FirstScene");
    }

   public void ChangeHowGameScene()
    {
        SceneManager.LoadScene("HowGMScene");
    }
    public void SkinChangeScene()
    {
        SceneManager.LoadScene("SkinChangeScene");
    }
   
}
