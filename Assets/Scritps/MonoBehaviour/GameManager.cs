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
        playerScript = ScriptableObject.CreateInstance<Player>();
        playerScript.Initialize();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    //TODO Wybieranie pocisku z JSON'a
    public static Projectile ChooseProjectile()
    {
        Projectile projectile = new Projectile();

        return projectile;
    }

    public static Enemy LoadEntity(Type entityType)
    {
        string data;
        return new Enemy(1, 1, new List<Ability>());
    }
    
}
