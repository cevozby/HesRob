using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D bulletRB;
    bool fire;

    private void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();

        if (!PlayerController.left && !fire)
        {
            //transform.Translate(Vector2.right * Time.deltaTime * speed);
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 20f,
            //    transform.position.y, transform.position.z), speed * Time.deltaTime);
            /*Vector3 endPos = new Vector3(transform.position.x + 20f, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);*/
            bulletRB.AddForce(Vector2.right * speed);

        }
        else if (PlayerController.left)
        {
            //transform.Translate(Vector2.left * Time.deltaTime * speed);
            /*transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 20f,
                transform.position.y, transform.position.z), speed * Time.deltaTime);*/
            bulletRB.AddForce(Vector2.left * speed);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hasar bullet");
            Destroy(gameObject);
            fire = false;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Temas");
        Destroy(gameObject, 0.1f);
        fire = false;
    }

}
