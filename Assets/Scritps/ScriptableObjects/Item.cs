﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{

    public string Name { get; private set; }
    public abstract void UseItem();

    
}
