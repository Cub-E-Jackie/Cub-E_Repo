using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  In dieser Klasse wird die Steuerung des Spiels definiert und verwaltet.
  - die Steuerung WÄHREND des Levels
  - die Steuerung des Spielers in horizontaler Richtung, nach links und rechts
  - abhängig von Spielmodus
  - Kollision abfangen und entsprechend andere Funktionen aufrufen
  
*/

public class SpielerInput : MonoBehaviour {
    // Use this for initialization


    public GameObject duckPref;
    public float step;
    public float smoothing;
    private Vector3 targetPos = Vector3.zero;
    public GameObject worldCube;

    /*
    GRUNDLAGE
    erstellt von oben nach unten:
                kz11 kz12
             kz23 kz22 kz21
             kz33 kz32 kz31
                kz41 kz42	
             kz51 kz52 kz53
          kz61 kz62 kz63 kz64
        kz71 kz72 kz73 kz74 kz75
        kz81 kz82 kz83 kz84 kz85
        kz91 kz92 kz93 kz94 kz95
          kz1a kz1b kz1c kz1d
             kz2a kz2b kz2c

    ks1(rechts) und ks2(links) sind Kopfseiten 
    */

    ////Grundlage			
    //GameObject kz11, kz12;  
    //GameObject kz21, kz22, kz23;  
    //GameObject kz31, kz32, kz33; 	   
    //GameObject kz41, kz42; 
    //GameObject ks1, ks2; 
    //GameObject kz51, kz52, kz53; 
    //GameObject kz61, kz62, kz63, kz64;	
    //GameObject kz71, kz72, kz73, kz74, kz75; 
    //GameObject kz81, kz82, kz83, kz84, kz85; 
    //GameObject kz91, kz92, kz93, kz94, kz95; 
    //GameObject kz1a, kz1b, kz1c, kz1d; 
    //GameObject kz2a, kz2b, kz2c; 

    ////Kopf
    //GameObject kopf1, kopf1a, kopf1b; // -
    //GameObject kopf2, kopf2a, kopf2b; // |
    //GameObject kopfs;
    //GameObject schnabel;
    //GameObject auger, augel;
    //GameObject pupr, pupl;
    //GameObject hals;

    ////Bauch vorne
    //GameObject bv1, bv1a, bv1b; // -
    //GameObject bv2, bv2a, bv2b; // |
    //GameObject bv3, bv3a, bv3b; // - seite 

    ////Bauch hinten
    //GameObject bh1, bh1a, bh1b, bh1c, bh1d, bh1e, bh1f;
    //GameObject bh2, bh2a, bh2b, bh2c, bh2d, bh2e, bh2f;
    //GameObject bh3, bh3a, bh3b, bh3c, bh3d;

    //Alle
    GameObject duck;
		

	void Start () {

        duck = Instantiate(duckPref);//new GameObject("Ente");/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/
        
        duck.name = "Duck";
        duck.transform.parent = this.transform;
        duck.transform.position = transform.position;
        //alle.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f,0.0f); //Farbe

        #region waste
        //Grundlage
        //kz11 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz11.transform.parent=alle.transform;
        //kz11.transform.localScale = new Vector3(0.8f,0.7f,1.0f); //Würfelgröße
        //kz11.transform.Translate(4.5f,5.55f,0.0f); //Position
        //kz11.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); //Farbe

        //kz12 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz12.transform.parent=alle.transform;
        //kz12.transform.localScale = new Vector3(0.8f,0.7f,1.0f);
        //kz12.transform.Translate(4.5f,5.55f,1.0f);
        //kz12.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz21 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz21.transform.parent=alle.transform;
        //kz21.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz21.transform.Translate(4.5f,5.0f,1.5f);
        //kz21.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz22 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz22.transform.parent=alle.transform;
        //kz22.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz22.transform.Translate(4.5f,5.0f,0.5f);
        //kz22.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz23 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz23.transform.parent=alle.transform;
        //kz23.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz23.transform.Translate(4.5f,5.0f,-0.5f);
        //kz23.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz31 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz31.transform.parent=alle.transform;
        //kz31.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz31.transform.Translate(4.5f,4.0f,1.5f);
        //kz31.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz32 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz32.transform.parent=alle.transform;
        //kz32.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz32.transform.Translate(4.5f,4.0f,0.5f);
        //kz32.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz33 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz33.transform.parent=alle.transform;
        //kz33.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz33.transform.Translate(4.5f,4.0f,-0.5f);
        //kz33.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz41 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz41.transform.parent=alle.transform;
        //kz41.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz41.transform.Translate(4.5f,3.5f,0.0f);
        //kz41.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz42 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz42.transform.parent=alle.transform;
        //kz42.transform.localScale = new Vector3(0.8f,1.0f,1.0f);
        //kz42.transform.Translate(4.5f,3.5f,1.0f);
        //kz42.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //ks1 = GameObject.CreatePrimitive(PrimitiveType.Cube); 
        //ks1.transform.parent=alle.transform;
        //ks1.transform.localScale = new Vector3(0.8f,1.0f,0.5f);
        //ks1.transform.Translate(4.5f,4.5f,2.0f);
        //ks1.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //ks2 = GameObject.CreatePrimitive(PrimitiveType.Cube); 
        //ks2.transform.parent=alle.transform;
        //ks2.transform.localScale = new Vector3(0.8f,1.0f,0.5f);
        //ks2.transform.Translate(4.5f,4.5f,-1.0f);
        //ks2.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz51 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz51.transform.parent=alle.transform;
        //kz51.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz51.transform.Translate(4.5f,2.75f,1.5f);
        //kz51.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz52 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz52.transform.parent=alle.transform;
        //kz52.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz52.transform.Translate(4.5f,2.75f,0.5f);
        //kz52.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz53 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz53.transform.parent=alle.transform;
        //kz53.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz53.transform.Translate(4.5f,2.75f,-0.5f);
        //kz53.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz61 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz61.transform.parent=alle.transform;
        //kz61.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz61.transform.Translate(4.5f,2.25f,-1.0f); 
        //kz61.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz62 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz62.transform.parent=alle.transform;
        //kz62.transform.localScale = new Vector3(0.8f,0.5f,1.0f); 
        //kz62.transform.Translate(4.5f,2.25f,0.0f); 
        //kz62.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz63 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz63.transform.parent=alle.transform;
        //kz63.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz63.transform.Translate(4.5f,2.25f,1.0f);
        //kz63.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz64 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz64.transform.parent=alle.transform;
        //kz64.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz64.transform.Translate(4.5f,2.25f,2.0f);
        //kz64.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz71 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz71.transform.parent=alle.transform;
        //kz71.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz71.transform.Translate(4.5f,1.75f,2.5f); 
        //kz71.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz72 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz72.transform.parent=alle.transform;
        //kz72.transform.localScale = new Vector3(0.8f,0.5f,1.0f); 
        //kz72.transform.Translate(4.5f,1.75f,1.5f); 
        //kz72.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz73 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz73.transform.parent=alle.transform;
        //kz73.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz73.transform.Translate(4.5f,1.75f,0.5f);
        //kz73.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz74 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz74.transform.parent=alle.transform;
        //kz74.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz74.transform.Translate(4.5f,1.75f,-0.5f);
        //kz74.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz75 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz75.transform.parent=alle.transform;
        //kz75.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz75.transform.Translate(4.5f,1.75f,-1.5f);
        //kz75.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz81 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz81.transform.parent=alle.transform;
        //kz81.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz81.transform.Translate(4.5f,1.25f,2.5f); 
        //kz81.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz82 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz82.transform.parent=alle.transform;
        //kz82.transform.localScale = new Vector3(0.8f,0.5f,1.0f); 
        //kz82.transform.Translate(4.5f,1.25f,1.5f); 
        //kz82.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz83 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz83.transform.parent=alle.transform;
        //kz83.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz83.transform.Translate(4.5f,1.25f,0.5f);
        //kz83.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz84 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz84.transform.parent=alle.transform;
        //kz84.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz84.transform.Translate(4.5f,1.25f,-0.5f);
        //kz84.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz85 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz85.transform.parent=alle.transform;
        //kz85.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz85.transform.Translate(4.5f,1.25f,-1.5f);
        //kz85.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz91 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz91.transform.parent=alle.transform;
        //kz91.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz91.transform.Translate(4.5f,0.75f,2.5f); 
        //kz91.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz92 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz92.transform.parent=alle.transform;
        //kz92.transform.localScale = new Vector3(0.8f,0.5f,1.0f); 
        //kz92.transform.Translate(4.5f,0.75f,1.5f); 
        //kz92.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz93 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz93.transform.parent=alle.transform;
        //kz93.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz93.transform.Translate(4.5f,0.75f,0.5f);
        //kz93.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz94 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz94.transform.parent=alle.transform;
        //kz94.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz94.transform.Translate(4.5f,0.75f,-0.5f);
        //kz94.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz95 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz95.transform.parent=alle.transform;
        //kz95.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz95.transform.Translate(4.5f,0.75f,-1.5f);
        //kz95.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz1a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz1a.transform.parent=alle.transform;
        //kz1a.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz1a.transform.Translate(4.5f,0.25f,-1.0f); 
        //kz1a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz1b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz1b.transform.parent=alle.transform;
        //kz1b.transform.localScale = new Vector3(0.8f,0.5f,1.0f); 
        //kz1b.transform.Translate(4.5f,0.25f,0.0f); 
        //kz1b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f); 

        //kz1c = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz1c.transform.parent=alle.transform;
        //kz1c.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz1c.transform.Translate(4.5f,0.25f,1.0f);
        //kz1c.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz1d = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz1d.transform.parent=alle.transform;
        //kz1d.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz1d.transform.Translate(4.5f,0.25f,2.0f);
        //kz1d.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz2a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz2a.transform.parent=alle.transform;
        //kz2a.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz2a.transform.Translate(4.5f,-0.25f,1.5f);
        //kz2a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz2b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz2b.transform.parent=alle.transform;
        //kz2b.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz2b.transform.Translate(4.5f,-0.25f,0.5f);
        //kz2b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kz2c = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kz2c.transform.parent=alle.transform;
        //kz2c.transform.localScale = new Vector3(0.8f,0.5f,1.0f);
        //kz2c.transform.Translate(4.5f,-0.25f,-0.5f);
        //kz2c.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //hals = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //hals.transform.parent=alle.transform;
        //hals.transform.localScale = new Vector3(1.3f,1.0f,1.0f);
        //hals.transform.Translate(4.5f,3.0f,0.5f);
        //hals.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);
        ////Grundlage Ende

        ////Kopf 
        ////(1 und 2 sind direkt an Grundlage, andere weiter weg je weiter im Alphabet, kopfs ist seite direkt an Grundlage)
        //kopf1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kopf1.transform.parent=alle.transform;
        //kopf1.transform.localScale = new Vector3(1.8f,1.5f,2.5f);
        //kopf1.transform.Translate(4.5f,4.5f,0.5f);
        //kopf1.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kopf2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kopf2.transform.parent=alle.transform;
        //kopf2.transform.localScale = new Vector3(1.8f,2.2f,1.5f);
        //kopf2.transform.Translate(4.5f,4.5f,0.5f);
        //kopf2.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kopf1a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kopf1a.transform.parent=alle.transform;
        //kopf1a.transform.localScale = new Vector3(2.5f,1.0f,2.0f);
        //kopf1a.transform.Translate(4.5f,4.5f,0.5f);
        //kopf1a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kopf2a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kopf2a.transform.parent=alle.transform;
        //kopf2a.transform.localScale = new Vector3(2.5f,1.8f,1.0f);
        //kopf2a.transform.Translate(4.5f,4.5f,0.5f);
        //kopf2a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kopf1b = GameObject.CreatePrimitive(PrimitiveType.Cube);//nur Hinterkopf
        //kopf1b.transform.parent=alle.transform;
        //kopf1b.transform.localScale = new Vector3(0.8f,0.5f,1.5f);
        //kopf1b.transform.Translate(5.5f,4.5f,0.5f);
        //kopf1b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kopf2b = GameObject.CreatePrimitive(PrimitiveType.Cube);//nur Hinterkopf
        //kopf2b.transform.parent=alle.transform;
        //kopf2b.transform.localScale = new Vector3(0.8f,1.5f,0.5f);
        //kopf2b.transform.Translate(5.5f,4.5f,0.5f);
        //kopf2b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //kopfs = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //kopfs.transform.parent=alle.transform;
        //kopfs.transform.localScale = new Vector3(1.3f,0.8f,3.0f);
        //kopfs.transform.Translate(4.5f,4.5f,0.5f);
        //kopfs.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //schnabel = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //schnabel.transform.parent=alle.transform;
        //schnabel.transform.localScale = new Vector3(1.0f,0.4f,1.8f);
        //schnabel.transform.Translate(2.8f,4.3f,0.5f);
        //schnabel.GetComponent<Renderer>().material.color = new Color(2.0f, 0.0f, 0.0f);

        //auger = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //auger.transform.parent=alle.transform;
        //auger.transform.localScale = new Vector3(0.5f,0.6f,0.3f);
        //auger.transform.Translate(3.4f,4.88f,0.3f);
        //auger.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f);

        //augel = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //augel.transform.parent=alle.transform;
        //augel.transform.localScale = new Vector3(0.5f,0.6f,0.3f);
        //augel.transform.Translate(3.4f,4.88f,0.7f);
        //augel.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f);

        //pupr = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //pupr.transform.parent=alle.transform;
        //pupr.transform.localScale = new Vector3(0.0f,0.2f,0.15f);
        //pupr.transform.Translate(3.13f,4.85f,0.3f);
        //pupr.GetComponent<Renderer>().material.color = new Color(0.0f, 0.0f, 0.0f);

        //pupl = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //pupl.transform.parent=alle.transform;
        //pupl.transform.localScale = new Vector3(0.0f,0.2f,0.15f);
        //pupl.transform.Translate(3.13f,4.85f,0.7f);
        //pupl.GetComponent<Renderer>().material.color = new Color(0.0f, 0.0f, 0.0f);
        ////Kopf Ende

        ////Bauch vorne
        //bv1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv1.transform.parent=alle.transform;
        //bv1.transform.localScale = new Vector3(0.6f,2.0f,3.4f);
        //bv1.transform.Translate(3.9f,1.25f,0.5f);
        //bv1.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bv2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv2.transform.parent=alle.transform;
        //bv2.transform.localScale = new Vector3(0.6f,3.2f,2.5f);
        //bv2.transform.Translate(3.9f,1.25f,0.5f);
        //bv2.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bv1a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv1a.transform.parent=alle.transform;
        //bv1a.transform.localScale = new Vector3(0.6f,1.6f,2.9f);
        //bv1a.transform.Translate(3.5f,1.25f,0.5f);
        //bv1a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bv2a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv2a.transform.parent=alle.transform;
        //bv2a.transform.localScale = new Vector3(0.6f,2.7f,2.0f);
        //bv2a.transform.Translate(3.5f,1.25f,0.5f);
        //bv2a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bv1b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv1b.transform.parent=alle.transform;
        //bv1b.transform.localScale = new Vector3(0.6f,1.2f,2.4f);
        //bv1b.transform.Translate(3.1f,1.25f,0.5f);
        //bv1b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bv2b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv2b.transform.parent=alle.transform;
        //bv2b.transform.localScale = new Vector3(0.6f,2.1f,1.5f);
        //bv2b.transform.Translate(3.1f,1.25f,0.5f);
        //bv2b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bv3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv3.transform.parent=alle.transform;
        //bv3.transform.localScale = new Vector3(0.5f,1.0f,4.3f);
        //bv3.transform.Translate(4.02f,1.25f,0.5f);
        //bv3.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);	

        //bv3a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv3a.transform.parent=alle.transform;
        //bv3a.transform.localScale = new Vector3(0.4f,0.6f,3.9f);
        //bv3a.transform.Translate(3.65f,1.25f,0.5f);
        //bv3a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);	

        //bv3b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bv3b.transform.parent=alle.transform;
        //bv3b.transform.localScale = new Vector3(0.5f,0.4f,3.45f);
        //bv3b.transform.Translate(3.35f,1.25f,0.5f);
        //bv3b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);			
        ////Bauch vorne Ende 

        ////Bauch hinten 
        //bh1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh1.transform.parent=alle.transform;
        //bh1.transform.localScale = new Vector3(0.63f,2.4f,4.0f);
        //bh1.transform.Translate(5.2f,1.25f,0.5f);
        //bh1.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh2.transform.parent=alle.transform;
        //bh2.transform.localScale = new Vector3(0.63f,3.4f,2.9f);
        //bh2.transform.Translate(5.2f,1.25f,0.5f);
        //bh2.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh1a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh1a.transform.parent=alle.transform;
        //bh1a.transform.localScale = new Vector3(0.63f,2.3f,3.9f);
        //bh1a.transform.Translate(5.7f,1.25f,0.5f);
        //bh1a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh2a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh2a.transform.parent=alle.transform;
        //bh2a.transform.localScale = new Vector3(0.63f,3.3f,2.8f);
        //bh2a.transform.Translate(5.7f,1.25f,0.5f);
        //bh2a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh1b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh1b.transform.parent=alle.transform;
        //bh1b.transform.localScale = new Vector3(0.63f,2.1f,3.7f);
        //bh1b.transform.Translate(6.3f,1.25f,0.5f);
        //bh1b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh2b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh2b.transform.parent=alle.transform;
        //bh2b.transform.localScale = new Vector3(0.63f,3.1f,2.6f);
        //bh2b.transform.Translate(6.3f,1.25f,0.5f);
        //bh2b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh1c = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh1c.transform.parent=alle.transform;
        //bh1c.transform.localScale = new Vector3(0.63f,1.8f,3.4f);
        //bh1c.transform.Translate(6.9f,1.25f,0.5f);
        //bh1c.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh2c = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh2c.transform.parent=alle.transform;
        //bh2c.transform.localScale = new Vector3(0.63f,2.8f,2.3f);
        //bh2c.transform.Translate(6.9f,1.25f,0.5f);
        //bh2c.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh1d = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh1d.transform.parent=alle.transform;
        //bh1d.transform.localScale = new Vector3(0.5f,1.3f,2.9f);
        //bh1d.transform.Translate(7.4f,1.37f,0.5f);
        //bh1d.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh2d = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh2d.transform.parent=alle.transform;
        //bh2d.transform.localScale = new Vector3(0.5f,2.3f,1.8f);
        //bh2d.transform.Translate(7.4f,1.37f,0.5f);
        //bh2d.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh1e = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh1e.transform.parent=alle.transform;
        //bh1e.transform.localScale = new Vector3(0.5f,0.9f,2.5f);
        //bh1e.transform.Translate(7.9f,1.76f,0.5f);
        //bh1e.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh2e = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh2e.transform.parent=alle.transform;
        //bh2e.transform.localScale = new Vector3(0.5f,1.9f,1.4f);
        //bh2e.transform.Translate(7.9f,1.76f,0.5f);
        //bh2e.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh1f = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh1f.transform.parent=alle.transform;
        //bh1f.transform.localScale = new Vector3(0.5f,0.5f,2.1f);
        //bh1f.transform.Translate(8.3f,2.14f,0.5f);
        //bh1f.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh2f = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh2f.transform.parent=alle.transform;
        //bh2f.transform.localScale = new Vector3(0.5f,1.5f,1.0f);
        //bh2f.transform.Translate(8.3f,2.14f,0.5f);
        //bh2f.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh3.transform.parent=alle.transform;
        //bh3.transform.localScale = new Vector3(0.63f,1.3f,4.9f);
        //bh3.transform.Translate(5.2f,1.25f,0.5f);
        //bh3.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh3a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh3a.transform.parent=alle.transform;
        //bh3a.transform.localScale = new Vector3(0.63f,1.1f,4.7f);
        //bh3a.transform.Translate(5.7f,1.25f,0.5f);
        //bh3a.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh3b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh3b.transform.parent=alle.transform;
        //bh3b.transform.localScale = new Vector3(0.63f,0.9f,4.5f);
        //bh3b.transform.Translate(6.3f,1.25f,0.5f);
        //bh3b.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);		

        //bh3c = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh3c.transform.parent=alle.transform;
        //bh3c.transform.localScale = new Vector3(0.63f,0.7f,4.3f);
        //bh3c.transform.Translate(6.9f,1.25f,0.5f);
        //bh3c.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);

        //bh3d = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //bh3d.transform.parent=alle.transform;
        //bh3d.transform.localScale = new Vector3(0.4f,0.5f,4.1f);
        //bh3d.transform.Translate(7.415f,1.37f,0.5f);
        //bh3d.GetComponent<Renderer>().material.color = new Color(3.0f, 1.0f, 0.0f);		
        ////Bauch hinten Ende


        ////Für Änderung der Position ohne bei den obendrüber rechnen zu müssen ;)
        //kopf1.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kopf2.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kopf1a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kopf2a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kopf1b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kopf2b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kopfs.transform.Translate(-4.5f, 6.0f, 0.0f);
        //schnabel.transform.Translate(-4.5f, 6.0f, 0.0f);
        //auger.transform.Translate(-4.5f, 6.0f, 0.0f);
        //augel.transform.Translate(-4.5f, 6.0f, 0.0f);
        //pupr.transform.Translate(-4.5f, 6.0f, 0.0f);
        //pupl.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz11.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz12.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz21.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz22.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz23.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz31.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz32.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz33.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz41.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz42.transform.Translate(-4.5f, 6.0f, 0.0f);
        //ks1.transform.Translate(-4.5f, 6.0f, 0.0f);
        //ks2.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz51.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz52.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz53.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz61.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz62.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz63.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz64.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz71.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz72.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz73.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz74.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz75.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz81.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz82.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz83.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz84.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz85.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz91.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz92.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz93.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz94.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz95.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz1a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz1b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz1c.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz1d.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz2a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz2b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //kz2c.transform.Translate(-4.5f, 6.0f, 0.0f);
        //hals.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv1.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv2.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv1a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv2a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv1b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv2b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv3.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv3a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bv3b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh1.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh2.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh1a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh2a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh1b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh2b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh1c.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh2c.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh1d.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh2d.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh1e.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh2e.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh1f.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh2f.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh3.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh3a.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh3b.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh3c.transform.Translate(-4.5f, 6.0f, 0.0f);
        //bh3d.transform.Translate(-4.5f, 6.0f, 0.0f);

        #endregion

    }

    /*	
	// Hier kommt der Trigger und Collider Teil zum realisieren der Kollisionen und zum abfangen der Ereignisse!
    void OnTriggerEnter(Collider other)
    {
		// wenn other == Schiffchen, Baumstamm ODER Ball ist, dann:
		
			// aktivModus auf false
			
			// leben - 1
			
			// Funbktionsaufruf von AnzahlLeben(leben) in Klasse UIverwaltung
			
			// Funbktionsaufruf von CameraZurueck() in Klasse CameraSteuerung
			
			// Funbktionsaufruf von CubeDrehen() in Klasse CubeSteuerung 
			
			// Funktionsaufruf von Feldwechsel() in Klasse Hindernisse
		
		// wenn other == QuietscheEnte, dann:
		
			// fortschritt + 1
			
			// Funbktionsaufruf von AnzahlFortschritt(fortschritt) in Klasse UIverwaltung
			
			// Zerstörung von diesem QuietscheEnte-Objekt -> Destroy(GameObject other);

    }

	*/

    void Update () {

        //GetComponent<Rigidbody>().AddForce((worldCube.transform.position - transform.position).normalized * 9.81f);
        //transform.LookAt(transform.position + Vector3.forward);

        //Vector3 schritt = new Vector3(0f, 0f, 10f);
		
		// Solange aktivModus auf true
		//if (SpielUeberwachung.aktivModus){
		
		//Spieler bei Tastenbedienung A Aufruf der Funktion BewegungSpieler(negative floatzahl)
		if( Input.GetKeyDown( KeyCode.D )){
        //duck.transform.position -= schritt * geschwindigkeit * Time.deltaTime;
            targetPos = transform.right * step;
		}
		
		//Spieler bei Tastenbedienung D Aufruf der Funktion BewegungSpieler(positive floatzahl)
		if(  Input.GetKeyDown( KeyCode.A )){
            targetPos = -(transform.right * step);
            //duck.transform.position += schritt * geschwindigkeit * Time.deltaTime;
        }


        transform.position += targetPos * smoothing;
        targetPos -= targetPos * smoothing;
        
        if (transform.position.x < -4) transform.position = new Vector3(-4, transform.position.y, transform.position.z);
        if (transform.position.x >  4) transform.position = new Vector3(4, transform.position.y, transform.position.z);

        //}

    }
}
