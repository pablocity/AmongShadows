using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
	public BulletType Type { get;  set; }

    public float HitPoints { get; set; }

    public bool IsDistance { get; set; }


    public Weapon(string name, float hitPoints, bool isDistance)
        : base()
    {
        Name = name;
        HitPoints = hitPoints;
        IsDistance = isDistance;
    }

}


//This enum is pointing the right bullet type for chosen weapon kind
public enum BulletType
{
    None,
}