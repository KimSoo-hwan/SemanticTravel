using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public GameObject player;
    public Material blue;
    public Material red;
    public Material Black;
    public Material Gray;
    public Material Green;
    public Material Yellow;
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
    
    public void SetBlack()
    {
        Renderer renderer = player.GetComponent<Renderer>();
        renderer.material = Black;
    }
    public void SetGray()
    {
        Renderer renderer = player.GetComponent<Renderer>();
        renderer.material = Gray;
    }
    public void SetGreen()
    {
        Renderer renderer = player.GetComponent<Renderer>();
        renderer.material = Green;
    }
    public void SetYellow()
    {
        Renderer renderer = player.GetComponent<Renderer>();
        renderer.material = Yellow;
    }
}
