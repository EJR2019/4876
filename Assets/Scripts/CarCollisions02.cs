using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollisions02 : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OffTheRoad")
        {
            Debug.Log("Collision detected");
            SceneManager.LoadScene("Chapter2Part1");
        }
        if (collision.gameObject.tag == "TransitionToC2P2")
        {

            SceneManager.LoadScene("Chapter2Part2");

        }
    }
}
