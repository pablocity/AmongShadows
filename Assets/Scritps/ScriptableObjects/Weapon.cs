using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : ScriptableObject
{
	public BulletType Type { get; private set; }

    public abstract void Attack(Entity enemy);

}


//This enum is pointing the right bullet type for chosen weapon kind
public enum BulletType
{
    None,
}