using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class C1P1Objectives02 : MonoBehaviour {

    public GameObject WD;
    public GameObject SK;
    public GameObject WF;
    public bool wardrobe = false;
    public bool sink = false;
    public bool waffle = false;
    public int objectives;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wardrobe")
        {
            wardrobe = true;
            Debug.Log("All dressed!");
            objectives++;
            print(objectives);
            Destroy(WD);
        }
        if (collision.gameObject.tag == "Sink")

        {
            sink = true;
            Debug.Log("Teeth brushed!");
            objectives++;
            print(objectives);
            Destroy(SK);
        }
        if (collision.gameObject.tag == "Waffle")
        {
            waffle = true;
            Debug.Log("Finished breakfast!");
            objectives++;
            print(objectives);
            Destroy(WF);
        }
        if (collision.gameObject.tag == "Exit" && objectives == 3)
        {
            SceneManager.LoadScene("Chapter1Part2");
            
            
        }
    }
}


