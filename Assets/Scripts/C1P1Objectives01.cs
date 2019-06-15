using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1L1objectives01
{

    private bool wardrobe = false;
    private bool sink = false;
    private bool waffle = false;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wardrobe")
        {
            wardrobe = true;
            Debug.Log("All dressed!");
        }
    }
}