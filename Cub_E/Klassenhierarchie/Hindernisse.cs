using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse soll alles rund um die Hindernisse im Level programmiert werden.
   - es werden verschiedene Arten von Hindernissen in unterschiedlichen Formen, bestehend aus kleinen Modulationen definiert
   - Hindernisse werden zufällig  im Level auf der akutellen Spielfläche generiert und platziert
   - Hindernisse bewegen sich auf die Spielfigur zu und raus aus dem Spielfeld
   - Hindernisse werden hinten am Ende des Feldes neu generiert
   
   - zu lösendes Problem: Wie verbindet man die Klasse und deren Verwaltungsvariablen mit den mehreren zeitgleich vorhandenen GameObjekten?
						  Wie steuert man die Variablen der jeweiligen GameObjekte explizit an?
						  Gibt es eine analoge Syntax: dieseQuietscheEnte.lifetime?
						  Man muss bei einer Kollision, dadurch ausgelöster Feldwechsel komplett alle bisher erzeugten Objekte löschen, und wieder mehrere neue sofort generieren
*/

public class Hindernisse : MonoBehaviour {
	
	
	//  Array zur Speicherung von Hindernissen als globale Variable???
   
	// globale Variable zur Speicherung des akutell zuletzt erzeugten Hindernisses
	public GameObject aktuellesHinderniss;
	
    private float timeCounterErzeugung = 120f/*Zeit nach der wieder ein neues Objekt erzeugt werden soll*/;
	
	// Variable für die zufällige Auswahl einer Art des neuen Objektes
	private int objektArt;

	// Initialisierung der Klasse
	void Start () {
		
		// Funktionsaufruf Feldwechsel() 
		
	}


    private void ErzeugeHindernis(/*int objektArt*/)
    {
		// Variable zur Speicherung des neu erstellten Objekts
		
		// zufällige Auswahl der Objektart des Hindernisses mit SwitchCase
	
			// wenn objektArt == 0,
				//dann Baumstamm()
				
			// wenn objektArt == 1,
				//dann Ball()
				
			// wenn objektArt == 2,
				//dann QuietscheEnte()
				
			// wenn objektArt == 3,
				//dann Schiffchen()
				
		//Positionsvektor nach Pattmann zur Positionierung des Objekts
        //Vector3 startPoint = new Vector3(Random.Range(-5f, 5), 10f, Random.Range(-5f, 5f));
        //Instantiate(hindernis, startPoint, Quaternion.identity);
    } 
	 
	
	
	 
	void Baumstamm (){
	
		// Erzeugung eines GameObjekts 
		
		// Vector3 startPoint = new Vector3(Random.Range(-5f, 5), 10f, Random.Range(-5f, 5f));
		// Instantiate(hindernis, startPoint, Quaternion.identity);

		//Speicherung und Zuweisung des Objekts in Form des vormodellierten Baums
	
	}
	
	void Ball (){
		
		// Erzeugung eines GameObjekts 

		//Speicherung und Zuweisung des Objekts in Form des vormodellierten Balls
	}
	
	void QuietscheEnte (){
	
		// Erzeugung eines GameObjekts 

		//Speicherung und Zuweisung des Objekts in Form der vormodellierten QuietscheEnte
	
	}
	
	void Schiffchen (){
	
		// Erzeugung eines GameObjekts 

		//Speicherung und Zuweisung des Objekts in Form des vormodellierten Schiffchens
	
	}
		
	/*das Spielfeld wird jedes Mal nach dem Aufruf den Funktion RotationHorizontal() oder RotationVertikal() 
	in der Klasse CubeSteuerung neu generiert*/
	void Feldwechsel() {
		
		// Funktion entfällt!!!
		
		// Funktionsaufruf von CameraVor() in Klasse CameraSteuerung
	}
	
	
	// Beschreibung der Bewegung der Hindernisse, Bewegung des Hindernisses auf Spielfigur zu (z-Achse)
	/* Diese Funktion vielleicht auch aus Translation des GameObjekts direkt in die Erzeugungsmethode */
	void Bewegung (/* GameObject hindernis */) {
	
	// Start der Bewegung 
	
	// Bewegung auf der z-Achse
	
	// Definition der Geschwindigkeit
	
	// Bereich der Bewegung (Feld) beachten

	
	}
	
	
	// Update is called once per frame
	void Update () {
	
	/*
	
	timeCounter += Time.deltaTime;
        if (timeCounter > 1f)
        {
            timeCounter = 0f;
			
			// Variable Objektart zufällig mit int Zahlen füllen, 
				0 - Baumstamm, schlecht
				1 - Ball, schlecht
				2 - QuietscheEnte, gut
				3 - Schiffchen, schlecht
				4 - QuietscheEnte, gut
				
            ErzeugeHindernis(objektArt);
        }	
	
	timer += Time.deltaTime;
		if (timer > lifetime)
		{
			Destroy(this.GameObject);
		}
		
	*/
			
	// Aufruf der Funktion Feldwechsel() sobald Aufruf Funktion RotationHorizontal() oder RotationVertikal() in Klasse CubeSteuerung
	
	// solange Aufruf der Funktion Bewegung(GameObject hindernis) aller Hindernisse, bis aktivModus auf false
			
	}
}
