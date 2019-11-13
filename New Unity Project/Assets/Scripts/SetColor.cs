using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public GameObject player;
    public Material blue;
    public Material red;
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRed() {
        Renderer renderer = player.GetComponent<Renderer>();
        renderer.material = red;
    }

    public void SetBlue() {
        Renderer renderer = player.GetComponent<Renderer>();
        renderer.material = blue;
    }
}
