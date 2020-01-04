using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UseComputer2 : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Computer2")
        {
            SceneManager.LoadScene("Chapter2Part6");
        }
    }
}
