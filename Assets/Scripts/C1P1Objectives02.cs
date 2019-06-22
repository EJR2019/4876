using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1P1Objectives02
{

    public bool wardrobe = false;
    public bool sink = false;
    public bool waffle = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wardrobe")
        {
            wardrobe = true;
            Debug.Log("All dressed!");
        }
        if (collision.gameObject.tag == "Sink")
        {
            sink = true;
            Debug.Log("Teeth brushed!");
        }
        if (collision.gameObject.tag == "Waffle")
        {
            waffle = true;
            Debug.Log("Finished breakfast!");
        }
    }
}
