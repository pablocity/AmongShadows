using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{
    /*
     
     Projectile variables are being filled by means of JSON file 
     describing proper type of projectile for each shooting weapon

    */

    [HideInInspector]
    public Vector2 direction;

    public Weapon weapon;

    //Pole reprezentujące efekt graficzny (wybuch, cząsteczki)

    //Pole dodające bonusowe obrażenia do pocisku

    public bool IsPlayer;
    public float Speed;
    public bool IsRebounded;

    private Vector2 lastVelocity;
    private Rigidbody2D rb;


    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = direction * Time.deltaTime * Speed;
    }

    void Update()
    {
        lastVelocity = rb.velocity;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            if (collision.gameObject.tag == "BoundedObstacle" && IsRebounded == true)
            {
                ContactPoint2D contact = collision.contacts[0];

                Vector2 reflect = Vector2.Reflect(lastVelocity, contact.normal);

                Debug.Log("Velocity: " + lastVelocity + " Normal vector: " + contact.normal + " Reflected: " + reflect);

                rb.velocity = reflect;
            }
            else
            {
                if (collision.gameObject.GetComponent<Entity>() != null)
                {
                    if (IsPlayer)
                    {
                        collision.gameObject.GetComponent<Entity>().Hit(GameManager.playerScript.HitPoints);
                    }
                    else
                    {
                        collision.gameObject.GetComponent<Entity>().Hit(weapon.HitPoints);
                    }
                }
                //TODO efekt graficzny
                Destroy(gameObject);
                return;
            }
            
        }
        else
        {
            return;
        }


    }


}
