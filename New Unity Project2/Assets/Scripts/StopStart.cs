using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopStart : MonoBehaviour
{
    public GameObject StopPanel;
    bool Isbool = false;
    public Sprite Start;
    public Sprite Stop;
    Image myImageComponent;

    public void ActivePauseBt()
    {
        myImageComponent = GetComponent<Image>();
        if (Isbool == false)
        {
            Time.timeScale = 0;
            Isbool = true;
            StopPanel.SetActive(true);
            myImageComponent.sprite = Stop;
        }
        else if (Isbool == true)
        {
            StopPanel.SetActive(false);
            Isbool = false;
            Time.timeScale = 1.0f;
            myImageComponent.sprite = Start;
        }
    }
}
