using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour {

	public TextMeshProUGUI textDisplay;
	public string[] sentences; //alles Sätze für den Dialog
	private int index;
	public float typingSpeed;
	public GameObject continueButton;
	
	void Start(){
		StartCoroutine(Type());
	}
	
	void Update(){
		
		
		if(textDisplay.text == sentences[index]){ //damit die Sätze nacheinander abgebildet und nicht gleichzeitig beim Drücken von Conitnue
			continueButton.SetActive(true);
		}
				
		
	}
	
	//Text anzeigen
	IEnumerator Type(){
		
		foreach(char letter in sentences[index].ToCharArray()){
			textDisplay.text += letter;
			yield return new WaitForSeconds(typingSpeed);
		}
	}
	
	//damit nach Continue drücken neuer Satz gezeigt wird
	public void NextSentence(){
		
		continueButton.SetActive(false);
		if(index<sentences.Length - 1){
			index++; //+1 gerechnet
			textDisplay.text = "";
			StartCoroutine(Type());
		} else {
			//textDisplay.text = "";
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //nächste Scene starten = Game
			continueButton.SetActive(false);
		}
	}
	
}
