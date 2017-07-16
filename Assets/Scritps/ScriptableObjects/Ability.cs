using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public string Name { get; private set; }

    public float CoolDown { get; set; }

    public float CurrentHitPoints { get; set; }

    public abstract void UseAbility();

}
