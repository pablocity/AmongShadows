using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public string Name { get; private set; }

    public bool IsPassive { get; private set; }

    public float CoolDown { get; set; }

    public float HitPoints { get; set; } // Amount of damage that ability can cause

    public abstract void Activate();

}
