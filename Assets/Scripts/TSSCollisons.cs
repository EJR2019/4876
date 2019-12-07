using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TSSCollisons : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asteriod")
        {
            Debug.Log("Collision detected");
            SceneManager.LoadScene("Chapter2Part3");

        }
        if (collision.gameObject.tag == "Mars")
        {
            SceneManager.LoadScene("Chapter2Part4");

        }
    }
}
