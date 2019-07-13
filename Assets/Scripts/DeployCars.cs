using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployCars : MonoBehaviour {
    public GameObject CarPrefab;
    public float respawnTime = 1.0f;
    private Vector2 ScreenBounds;

    // Use this for initialization
    void Start () {
        ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(CarWave());
    }
	
    private void spawnCar()
    {
        GameObject c = Instantiate(CarPrefab) as GameObject;
        c.transform.position = new Vector2(ScreenBounds.x * 2, Random.Range(-ScreenBounds.y, ScreenBounds.y));
    }
    IEnumerator CarWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCar();
        }
       
    }
	
}
