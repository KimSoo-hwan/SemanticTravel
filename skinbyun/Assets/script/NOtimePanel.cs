using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOtimePanel : MonoBehaviour
{
    public GameObject Panel;
    bool Isbool = false;
    public void OpenPanel()
    {

        if (Isbool == false)
        {
            Isbool = true;
            Panel.SetActive(true);
            Debug.Log("I CAN'T SEE");
        }
        else if (Isbool == true)
        {

            Panel.SetActive(false);
            Isbool = false;
            Debug.Log("Yabal");
        }

    }
}
