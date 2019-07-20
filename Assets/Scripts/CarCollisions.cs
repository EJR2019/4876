using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisions : MonoBehaviour {

 private void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("Collision detected");
    }
}
