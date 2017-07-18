using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [HideInInspector]
    public static GameObject Player;
    public static Player playerScript;

	// Use this for initialization
	void Start ()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerScript = Player.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    
}
