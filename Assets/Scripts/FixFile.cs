using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFile : MonoBehaviour {

    public Sprite FixingFile;

    public Sprite FileFixed;

    private void OnMouseDown()
    {
        FixingTheFile();

        Invoke("FixingTheFile", 10f);
        this.GetComponent<SpriteRenderer>().sprite = FileFixed;
    }
    public void FixingTheFile()
    {
        this.GetComponent<SpriteRenderer>().sprite = FixingFile;
    }
}
