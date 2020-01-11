using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToC2P7 : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("Chapter2Part7");
        }
    }
}
