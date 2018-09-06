using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour {
	
	//Datei ist dafür, dass man die Lautstärke im Spiel ändern kann
	//Muss innerhalb unity auch Änderungen vornehmen, also aufpassen!
	
	public AudioMixer audioMixer;

	public void SetVolume (float volume) {
		audioMixer.SetFloat("volume", volume);
	}
}
