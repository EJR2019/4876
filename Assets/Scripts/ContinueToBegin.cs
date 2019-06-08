using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ContinueToBegin : MonoBehaviour {
	public void Continue ()
	{
		SceneManager.LoadScene("Chapter1Part1");
	}
}
