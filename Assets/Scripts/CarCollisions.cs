using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollisions : MonoBehaviour {

    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "KillerCar")
        {
            Debug.Log("Collision detected");
            SceneManager.LoadScene("Chapter1Part2");

        }
        if (collision.gameObject.tag == "TransitionToC1P3")
        {
           
            SceneManager.LoadScene("Chapter1Part3");

        }

    }
}
