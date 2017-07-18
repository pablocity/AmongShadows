using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviours : MonoBehaviour {


    [SerializeField]
    [Range(0, 10)]
    public float Speed = 5f;

    public LayerMask toHit;

    IEnumerator currentCoroutine = null;

    Bounds boundaries;

    void Start ()
    {
        boundaries = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>().bounds;
    }
	

	void Update ()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }


        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {

            if (!CheckPosition(Vector2.right))
                return;


            if (currentCoroutine != null)
            {
                StopCoroutine(currentCoroutine);
            }

            currentCoroutine = MoveCoroutine(Vector3.right, Speed);
            StartCoroutine(currentCoroutine);

        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {

            if (!CheckPosition(Vector2.left))
                return;


            if (currentCoroutine != null)
            {
                StopCoroutine(currentCoroutine);
            }

            currentCoroutine = MoveCoroutine(Vector3.left, Speed);
            StartCoroutine(currentCoroutine);
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {

            if (!CheckPosition(Vector2.up))
                return;


            if (currentCoroutine != null)
            {
                StopCoroutine(currentCoroutine);
            }

            currentCoroutine = MoveCoroutine(Vector3.up, Speed);
            StartCoroutine(currentCoroutine);
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {

            if (!CheckPosition(Vector2.down))
                return;


            if (currentCoroutine != null)
            {
                StopCoroutine(currentCoroutine);
            }

            currentCoroutine = MoveCoroutine(Vector3.down, Speed);
            StartCoroutine(currentCoroutine);
        }
    }


    IEnumerator MoveCoroutine(Vector3 dir, float speed)
    {
        Vector3 smallerDir = new Vector3(dir.x / 4, dir.y / 4);
        Vector3 destination = gameObject.transform.position + smallerDir;

        while (gameObject.transform.position != destination)
        {
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, destination, speed * Time.deltaTime);
            yield return null;
        }
    }

    private bool CheckPosition(Vector3 move)
    {

        if (transform.position.x + move.x > boundaries.size.x / 2 || transform.position.x + move.x < -boundaries.size.x / 2
            || transform.position.y + move.y > boundaries.size.y / 2 || transform.position.y + move.y < -boundaries.size.y / 2)
            return false;
        else
            return true;

    }

    private void Attack()
    {
        Item currentItem = GameManager.playerScript.currentItem;

        if (currentItem != null)
        {
            if (currentItem is Weapon)
            {
                Weapon weapon = currentItem as Weapon;

                Vector3 differance = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y)
                        - transform.position;


                if (weapon.IsDistance)
                {
                    //TODO dokończyć

                    weapon.Bullet.weapon = weapon;


                }
                else
                {
                    RaycastHit2D hit = Physics2D.Raycast(GameManager.Player.transform.position, differance, weapon.Distance, toHit);

                    if (hit.collider != null)
                    {
                        if (hit.collider.gameObject.GetComponent<Entity>() != null)
                        {
                            hit.collider.gameObject.GetComponent<Entity>().Hit(GameManager.playerScript.HitPoints);
                        }
                        //TODO zmienić Item na klasę reprezentującą obiekt gry jeśli konieczne
                        else if (hit.collider.gameObject.GetComponent<Item>() != null)
                        {
                            Destroy(hit.collider.gameObject);
                        }
                    }
                }
            }
            else
                currentItem.UseItem();
        }
        else
            Debug.LogError("You have neither weapon nor item!");
    }
}
