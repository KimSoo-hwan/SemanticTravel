using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionScene : MonoBehaviour
{
    public static int Snum;
    public void ChangeOptionScene()
    {
        if (SceneManager.GetActiveScene().name == "Sematic Travel")
            Snum = 0;
        else if (SceneManager.GetActiveScene().name == "Sematic Travel 1")
            Snum = 1;
        else if (SceneManager.GetActiveScene().name == "Sematic Travel 2")
            Snum = 2;
        else if (SceneManager.GetActiveScene().name == "Sematic Travel 3")
            Snum = 3;
        else if (SceneManager.GetActiveScene().name == "Sematic Travel 4")
            Snum = 4;
        SceneManager.LoadScene("Sematic OptionScene");
    }
    public void ChangeFirstScene()
    {
        if (Snum == 0)
            SceneManager.LoadScene("Sematic Travel");
        else if (Snum == 1)
            SceneManager.LoadScene("Sematic Travel 1");
        else if (Snum == 2)
            SceneManager.LoadScene("Sematic Travel 2");
        else if (Snum == 3)
            SceneManager.LoadScene("Sematic Travel 3");
        else if (Snum == 4)
            SceneManager.LoadScene("Sematic Travel 4");
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
