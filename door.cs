using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour {

	public int leveltoload;    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Application.LoadLevel(leveltoload);                                 
        }        
    }          
}
