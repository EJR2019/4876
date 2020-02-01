using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2Complete : MonoBehaviour {

    public GameObject chapterCompletePopUP;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void HidePopUp()
    {
        chapterCompletePopUP.SetActive(false);
    }

    public void ShowPopUp(){
        chapterCompletePopUP.SetActive(true);
    }
}
