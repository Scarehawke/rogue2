using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class HighscoreText : MonoBehaviour {

	// Use this for initialization
	void Start () {

		string path = System.IO.Directory.GetCurrentDirectory () + "\\highscore.txt";
		if (!System.IO.File.Exists (path)) {
			System.IO.StreamWriter file = new System.IO.StreamWriter (path);
			file.WriteLine ("0");
			file.Close ();
		}
			

		GetComponent<Text> ().text = "Current Highscore: " + System.IO.File.ReadAllText (path).ToString();
	}

}
