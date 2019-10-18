using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStop : MonoBehaviour
{
    private bool pauseOn = false;
    public void ActivePauseBt()
    {
        if(!pauseOn)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
        pauseOn = !pauseOn;
    }
}
