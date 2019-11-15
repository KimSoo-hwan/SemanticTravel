using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject ExitPanel;
    bool Isbool = false;

    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Button Click");
    }

    public void ExitPanelOpen()
    {
       
        if(Isbool==false)
        {
            Isbool = true;
            ExitPanel.SetActive(true);
        }
        else if(Isbool==true)
        {
            ExitPanel.SetActive(false);
            Isbool = false;
        }
        
    }
    public void CloseExit()
    {
        if(Isbool==true)
        {
            ExitPanel.SetActive(false);
        }
    }
}
