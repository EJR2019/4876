using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayOfficer : MonoBehaviour {

    public GameObject stopper;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Officer") {
            Destroy(stopper);
            Debug.Log("Ticket payed.");
        }

        
    }
}
