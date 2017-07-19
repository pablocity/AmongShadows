using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{

    public Enemy(float health, float hitPoints, List<Ability> abilities)
    {
        Health = health;
        HitPoints = hitPoints;
        Abilities = abilities;
    }

    
}
