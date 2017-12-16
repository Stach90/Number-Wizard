using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		Random rnd = new Random();
		max = Random.Range(1, 10000);
		min = 1;
		guess = max/2;
		
		
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower then " + guess);
		print ("Up = higher, down = lower, return = equal");
		
		max = max + 1;
	}
	
	void NextGuess () {
		guess = (max + min) /2;
		print ("higher or lower then " + guess);
		print ("Up = higher, down = lower, return = equal");
	}
	
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("Up arrow pressed");
			
			min = guess;
			NextGuess ();
			
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("Down arrow pressed");
			
			max = guess;
			NextGuess ();
			
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
}
