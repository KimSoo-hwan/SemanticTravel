using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class option2 : MonoBehaviour
{
    public GameObject HowGmPanel;
    bool Isbool = false;
    public void OpenPanel()
    {

        if (Isbool == false)
        {
            Isbool = true;
            HowGmPanel.SetActive(true);
            Debug.Log("I CAN'T SEE");
        }
        else if (Isbool == true)
        {

            HowGmPanel.SetActive(false);
            Isbool = false;
        }

    }
}
