using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHelper : MonoBehaviour {

	public int currentLevel = 1;
	public int enemySpawnRate = 10;
    public int foodSpawnRate = 10;
    public int numRooms = 2;
	public int designCount = 1;


    public string[] action;


    void Start () {
		DontDestroyOnLoad (this);

		if (GameObject.FindGameObjectsWithTag ("LevelHelper").Length > 1) {
			Destroy (gameObject);
		}

	}

}
