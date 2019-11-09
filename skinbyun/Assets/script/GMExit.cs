using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMExit : MonoBehaviour
{
   public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Button Click");
    }
}
