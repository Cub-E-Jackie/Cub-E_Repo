using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse werden die organisatorischen Dinge sozusagen aus dem Hintergrund  geregelt.
   - globale Variablen zur Verwaltung des Spiels generiert und verwaltet
   - die Größen aus dem Menü werden implementiert und verwaltet
   - das Menü selbst wird gesteuert mithilfe von globalen Variablen
   - das Spiel wird beendet und gestartet
   - die Spielzeit wird hier in einer Variable gespeichert und verwaltet

*/

public class SpielUeberwachung : MonoBehaviour {

	// globale Variable zur Speicherung der Anzahl Leben (int)-> public für Klassen UIverwaltung, SpielerInput
	// globale Variable zur Speicherung des Fortschritts (int) -> public für Klassen UIverwaltung, SpielerInput
	// globale Variable zur Speicherung der Spielzeit(float) -> public für Klasse UIverwaltung
	// globale Variable zur Verwaltung des Spielmodus (bool)-> public für Klassen UIverwaltung, SpielerInput, CameraSteuerung, Hindernisse, CubeSteuerung
	static public bool aktivModus;

	// Start der Klasse ab Beginn des Programms, dies ist die erste Klasse!!!
	void Start () {
	
		// Initialisieren von den globalen Variablen
		
		// Funktionsaufruf Startmenü()
			
	}

	
	// Update is called once per frame
	void Update () {
	
	// wenn Leben == 0, dann:
	
		// Funktionsaufruf GameOver() in UIverwaltung
		
	// wenn Fortschritt == y, dann: 
	
		// Funktionsaufruf Siegmenü() in UIverwaltung
	
	// Messen der Spielzeit, speichern der Zeit in globaler Variable
	
	
	
	}
}
