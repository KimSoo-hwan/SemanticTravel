using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject Panel;
    bool Isbool = false;
    public void OpenPanel()
    {

        if (Isbool == false)
        {
            Time.timeScale = 0f;
            Isbool = true;
            Panel.SetActive(true);
            Debug.Log("Good");
        }
        else if (Isbool == true)
        {

            Panel.SetActive(false);
            Isbool = false;
            Time.timeScale = 1;
        }

    }
}
