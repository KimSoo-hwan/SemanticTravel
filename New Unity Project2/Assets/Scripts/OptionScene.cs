using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionScene : MonoBehaviour
{
   public void ChangeOptionScene()
    {
        SceneManager.LoadScene("Sematic OptionScene");
    }
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("Sematic Travel");
    }
    public void ChangeSkinScene()
    {
        SceneManager.LoadScene("Sematic SkinScene");
    }
    public void ChangeHowScene()
    {
        SceneManager.LoadScene("Sematic HowGmScene");
    }
    public void ChangeExitScene()
    {
        SceneManager.LoadScene("Sematic ExitScene");
    }
}
