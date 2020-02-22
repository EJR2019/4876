using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadChapter1() {
        SceneManager.LoadScene("Chapter1Part1");
    }

    public void LoadChapter2() {
        SceneManager.LoadScene("Chapter2Part1");
    }
}
