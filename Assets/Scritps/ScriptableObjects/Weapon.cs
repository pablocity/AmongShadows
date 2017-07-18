using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
	public BulletType Type { get;  private set; }

    public bool IsDistance { get; private set; }

    public bool IsPlayer { get; private set; }

    public float HitPoints { get; set; }

    public float Distance { get; set; }

    public Projectile Bullet { get; private set; }


    public Weapon(string name, float hitPoints, bool isDistance, float distance, bool isPlayer)
        : base()
    {
        Name = name;
        HitPoints = hitPoints;
        IsDistance = isDistance;
        Distance = distance;
        IsPlayer = isPlayer;
        Bullet = GameManager.ChooseProjectile();
    }

}


//This enum is pointing the right bullet type for chosen weapon kind
public enum BulletType
{
    None,
}