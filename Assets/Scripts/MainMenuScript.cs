using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour {
	public void StartGame ()
	{
		SceneManager.LoadScene("Intro");
	}
	public void ChapterSelect ()
	{
		SceneManager.LoadScene("ChapterSelect");
	}
	public void QuitGame()
	{
		Debug.Log("Game ended.");
		Application.Quit ();
	}
}
