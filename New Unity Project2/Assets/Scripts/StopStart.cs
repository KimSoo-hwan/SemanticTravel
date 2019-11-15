using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopStart : MonoBehaviour
{
    public GameObject StopPanel;
    bool Isbool = false;

    public void ActivePauseBt()
    {
        if (Isbool == false)
        {
            Time.timeScale = 0;
            Isbool = true;
            StopPanel.SetActive(true);
        }
        else if (Isbool == true)
        {
            StopPanel.SetActive(false);
            Isbool = false;
            Time.timeScale = 1.0f;
        }
    }
}
