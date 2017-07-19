using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    [HideInInspector]
    public Enemy enemyStats;

    [Range(0, 3)]
    public int EntityType;

	// Use this for initialization
	void Start ()
    {
        enemyStats = GameManager.LoadEntity((Type)EntityType);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
