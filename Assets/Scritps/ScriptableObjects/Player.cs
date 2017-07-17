using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {


    private List<Item> inventory;
    private Item currentItem;

    public override void Attack(Entity enemy)
    {

        if (currentItem != null)
        {
            if (currentItem is Weapon)
            {
                Weapon weapon = currentItem as Weapon;

                weapon.Attack(enemy);
            }
            else
            {
                currentItem.UseItem();
            }
        }
        else
        {
            if (enemy != null)
                enemy.Hit(this.HitPoints);
        }
        
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

}
