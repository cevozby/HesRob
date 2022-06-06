using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float speed;

    int health = 90;

    bool right, left;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= minX)
        {
            //transform.Translate(Vector2.right * Time.deltaTime * speed);
            //left = false;
            //right = true;
            transform.position = Vector3.MoveTowards(transform.position, 
                new Vector3(maxX, transform.position.y, transform.position.z), Time.deltaTime * speed);
            left = true;
            right = false;
        }
        if(transform.position.x >= maxX )
        {
            //transform.Translate(Vector2.left * Time.deltaTime * speed);
            //right = false;
            //left = true;
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(minX, transform.position.y, transform.position.z), Time.deltaTime * speed);
            right = true;
            left = false;
        }

        if (left)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(maxX, transform.position.y, transform.position.z), Time.deltaTime * speed);
        }
        else if (right)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(minX, transform.position.y, transform.position.z), Time.deltaTime * speed);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("öldüm");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= 30;
            Debug.Log("Hasar verdin");
            Destroy(collision.gameObject);

            if (health <= 0)
            {
                Destroy(gameObject);
                Debug.Log("öldüm");
            }


        }
    }

}
