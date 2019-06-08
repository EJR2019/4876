using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1L1objectives {

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
    }
}
