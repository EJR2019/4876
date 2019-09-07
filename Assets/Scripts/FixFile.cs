using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FixFile : MonoBehaviour {

    public bool TaskFinished;

    public AudioSource Loading;

    public Sprite FixingFile;

    public Sprite FileFixed;

    private void OnMouseDown()
    {
        FixingTheFile();
        Loading.Play();
        Invoke("FixingTheFile", 8f);
        FileIsFixed();
        Invoke("FileIsFixed", 2f);
        TaskFinished = true;
        Debug.Log("Task complete!");
    }
    public void FixingTheFile()
    {
        this.GetComponent<SpriteRenderer>().sprite = FixingFile;
    }
    public void FileIsFixed()
    {
        this.GetComponent<SpriteRenderer>().sprite = FileFixed;
    }
   
    void Start()
    {
        TaskFinished = false;
        if (Input.GetKeyDown("space") && TaskFinished == true)
        {
            SceneManager.LoadScene("ChapterComplete(C1)");
        }
    }
}
