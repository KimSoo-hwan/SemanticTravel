using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionScene : MonoBehaviour
{
   public void ChangeOptionScene()
    {
        SceneManager.LoadScene("Semantic OptionScene");
    }

    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("Semantic Travel");
    }

    public void ChangeSkinScene()
    {
        SceneManager.LoadScene("Semantic SkinScene");
    }

    public void ChangeHowScene()
    {
        SceneManager.LoadScene("Semantic HowGmScene");
    }
}
