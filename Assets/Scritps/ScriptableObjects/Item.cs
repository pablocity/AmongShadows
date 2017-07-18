using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{

    public string Name { get; protected set; }
    public virtual void UseItem()
    {
        if (this is Weapon)
            Debug.Log("You can just attack cause it is a weapon!");
    }

    
}
