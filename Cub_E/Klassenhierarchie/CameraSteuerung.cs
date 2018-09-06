using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	In dieser Klasse wird das Verhalten und die Positionen der Kamera in dem Spiel verwaltet. 
	- Am Anfang soll sie weit entfernt auf das ganze Universum von Cube-E zeigen. 
	- Mit einem Klick auf den Startbutton im Startmenü zoomt die Kamera auf den jeweiligen Cube-E.
	- Während des Levels bewegt sich die Kamera mit einer Verzögerung mit dem Spieler nach links und rechts. Also eine verzögerte Verfolgung des Spielers.
	- Bei Kollision mit Hindernis Camera zoomt kurz ein bisschen raus und dann wieder rein zum neuen Spielfeld. 
	- Am Ende, sowohl bei einem Sieg als auch bei einem GameOver wird wieder heraus gezoomt und das Universum sieht man. 
	
	Hinweise aus der Übung von Herrn Pattmann:
	Camera nicht parenten -> langweilig, smooth follow ist das Stichwort Google nicht die Standart Assets (Betrug!!!), 
	Hereinzoomen bei Start auf den Klick auf den Button dann mit Kamrea reinzoomen mithilfe von Vector 3. SmoothDamp, Angabe von Zeit, Beschleunigung, Vectorziel und so weiter
*/

public class CameraSteuerung : MonoBehaviour {

	//		public float GameObject target;

	
	void Start () {
	
	// Aufruf der Funktion Startbewegung
		
	}
	
	
	void Startbewegung (){
	
	// Ausgangsposition definieren
	
	//die Position des aktuellen Levels und Cube-E holen und in Variable Vector3 speichern
	
	// if der Spieler klickt auf UIverwaltung.startbutton dann beginnt zoom zum Zielcube-E
	
	// durch die feste Funktion Vector3.SmoothDamp und der Angabe von Zeit... Bewegung definieren, den Zoom
	//Ziel davon ist oben Zielvector 3
	
	// Funktionsaufruf Levelsicht()
	
	}
	
	
	void Levelsicht (){
	
	//Kamera Blick verbinden mit Spieler nicht durch follow und parented sondern durch LookAt, oder in Update()-Funktion???
	
	//		Kamera schaut immer zum Spieler das ist der erste Schritt
			//transform.LookAt(target.transform.position); //Hilfe von Patti
	
	//Kamera bewegt sich nach links und rechts hinter dem Spieler her
	
	//wenn jetzt das Spiel abbricht oder aufhört, dann
	// Aufruf der Funktion Endbewegung
	}
	
	
	// Camera ein bisschen zurück, damit Drehung zur Geltung kommt, bei Kollision
	void CameraZurueck (){
	
	}
	
	
	// Camera wieder in Feld und wieder Levelsicht
	void CameraVor(){
	
	
	// setzen von aktivModus auf true
	
	}
	
	
	//Kamera muss jetzt wieder rauszoomen, bis weit weg
	void Endbewegung(){
	
	
	}
	
	
	// Update is called once per frame
	void Update () {
	
	// evtl. hier der Code von Levelsicht() rein weil Bewegung dauerhaft aktualisiert wird
	
		
	}
}
