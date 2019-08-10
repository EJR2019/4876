using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UseComputer : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Computer")
        {
            Debug.Log("Using computer");
            SceneManager.LoadScene("Chapter1Part4");

        }
    }
}