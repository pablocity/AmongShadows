using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : ScriptableObject
{

	public float Health { get; private set; }

    public Type EntityType { get; set; } // na podstawie tej właściwości odpowiednie statystyki zostaną zapisane w zmiennych Istoty (z pliku JSON)

    public List<Ability> abilities;

    public abstract void Move();

    public abstract void Attack();

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
}


public enum Type
{
    Player,
    Knight,
    Bandit,
    Recon
}
