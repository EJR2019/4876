using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFile : MonoBehaviour {

    public AudioSource Loading;

    public Sprite FixingFile;

    public Sprite FileFixed;

    private void OnMouseDown()
    {
        FixingTheFile();
        Loading.Play();
        Invoke("FixingTheFile", 8f);
        this.GetComponent<SpriteRenderer>().sprite = FileFixed;
       
    }
    public void FixingTheFile()
    {
        this.GetComponent<SpriteRenderer>().sprite = FixingFile;
       
    }
}
