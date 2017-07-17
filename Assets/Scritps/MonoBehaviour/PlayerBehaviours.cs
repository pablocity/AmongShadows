using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviours : MonoBehaviour {


    [SerializeField]
    [Range(0, 10)]
    public float Speed = 5f;

    IEnumerator currentCoroutine = null;

    Bounds boundaries;

    void Start ()
    {
        boundaries = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>().bounds;
    }
	

	void Update ()
    {
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
}
