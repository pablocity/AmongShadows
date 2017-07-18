using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : ScriptableObject
{

	public float Health { get; private set; }

    public float HitPoints { get; set; } // Variable that store the current value of hit points calculated by means of equipped weapon and active passive abilities

    public Type EntityType { get; set; } // Based on this property the appropriate statistics will be saved in Entity's variables (from JSON file)

    public List<Ability> abilities;

    public virtual bool Hit(float hitPoints)
    {
        Health -= hitPoints;
        return IsDead();
    }

    private bool IsDead()
    {
        if (Health > 0)
            return true;
        else
            return false;
    }


    public abstract void Initialize();

}


public enum Type
{
    Player,
    Knight,
    Bandit,
    Recon
}
