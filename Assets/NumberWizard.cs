using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;

	public int maxGuessesAllowed = 5;

	public Text text;


	void Start () {
		StartGame();
	}
	
	void StartGame () {
		Random rnd = new Random();
		max = Random.Range(1, 10000);
		min = 1;
		//guess = max/2;
		NextGuess();

		max = max + 1;
	}



	public void GuessHigher(){
			min = guess;
			NextGuess ();
	}

	public void GuessLower(){
			max = guess;
			NextGuess ();
	}


	public void NextGuess () {
		guess = (max + min) /2;
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene("Win");
		}
	}


}
