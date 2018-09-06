using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Just a note for Unity C# users, you must specify "System.Random()" as Unity has a "UnityEngine.Random()" which clashes (note that "UnityEngine.Random()" doesn't have the ability to generate random numbers).

/*
   In dieser Klasse wird alles rund um den Cube programmiert.
   - Cube wird erzeugt 
   - das Rotationsverhalten gesteuert
   - das Rotationsverhalten definiert
 */

public class CubeSteuerung : MonoBehaviour {

	// Variable drehrichtung (private, int)
	private int drehrichtung;
    public Vector2 textureSpeed;

	// Beim Start des Programms soll der Cube sofort erzeugt werden und im Hintergrund sichtbar sein.
	void Start () {
	
		//Erzeugung des Cube, nicht per Code erzeugen, also als primitiver Körper in Unity
		
		//CubeDrehen();
		
		//Hinzufügen der Wasseroberfläche
		
	}
	
	// Rotationsverhalten definiert
	/* 
	Funktionsaufruf durch die Methode Kollision() in Klasse Hindernisse,
	globale Variable kollision aus SpielUeberwachung auf true
	*/
	private void CubeDrehen (){

        //System.Random zufall = new System.Random();
        // Initialisieren von drehrichtung mit Zufallszahlen zwischen und einschließlich 0 und 3 (vier Möglichkeiten!)
        //drehrichtung = zufall.Next( 0,  4);
        int rnd = Random.Range(0, 4);
		
		//Auswahl der Rotationsrichtung mit SwitchCase
		switch (drehrichtung){
		
			// wenn drehrichtung == 0, 
					//dann RotationHorizontal(float richtung);
			case 0: RotationHorizontal( 90);
					break;
				
				
			// wenn drehrichtung == 1, 
				//dann RotationHorizontal(float - richtung);
			case 1: RotationHorizontal (-90);
					break;
			
			// wenn drehrichtung == 2, 
				//dann RotationVertikal(float richtung);
			case 2: RotationVertikal ( 90);
					break;
					
			// wenn drehrichtung == 3, 
				//dann RotationVertikal(float - richtung);
			case 3: RotationVertikal (-90);
					break;

            default: break;
        }
				
	}
	
	//Rotationsbewegung nach oben oder unten programmieren
	void RotationVertikal (float richtung){
	
		float geschwindigkeit = 1f;
	
		// globale Variable aktivModus auf false, zur Organisation von SpielerInput
		SpielUeberwachung.aktivModus = false;
	
		// Cube dreht sich vertikal um x Achse um übergebenen Winkel 
		transform.Rotate(new Vector3(richtung,0,0), geschwindigkeit);
		
		//alternativ???
		//transform.eulerAngles += new Vector3(0f, 0f, richtung);
		
		// Funktionsaufruf Feldwechsel() der Klasse Hindernisse
		//geht noch nicht 	Hindernisse.Feldwechsel();
		
		// globale Variable aktivModus auf true, zur Organisation von SpielerInput
		SpielUeberwachung.aktivModus = true;
		
	}
	
	//Rotationsbewegung nach links oder rechts programmieren
	void RotationHorizontal (float richtung){
	
		//float geschwindigkeit = 100f;
	
		// globale Variable aktivModus auf false, zur Organisation von SpielerInput
		SpielUeberwachung.aktivModus = false;
	
		// Cube dreht sich vertikal um y Achse um übergebenen Winkel 
		transform.Rotate(new Vector3(0,richtung,0));
		
		// Funktionsaufruf Feldwechsel() der Klasse Hindernisse
		// geht noch nicht 	Hindernisse.Feldwechsel();
		
		// globale Variable aktivModus auf true, zur Organisation von SpielerInput
		SpielUeberwachung.aktivModus = true;
		
	}
	
	
	// Update in bestimmten Zeitabständen während des Spiels, nicht nötig da externer Funktionsaufruf der Bewegung
	void Update () {

        Material mat = GetComponent<Renderer>().material;
        mat.SetTextureOffset("_MainTex",  mat.GetTextureOffset("_MainTex") + textureSpeed);


	}
}
