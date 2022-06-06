using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManagement : MonoBehaviour
{
    Robot player = new Robot(100, 10, 15);
    float health;

    [SerializeField] GameObject gameOver;
    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = player.Health;
        healthBar.minValue = 0;
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;
        if (health <= 0)
        {
            gameOver.SetActive(true);
        }
    }
    
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("smallDamage")) 
        {
            Debug.Log("Hasar Alındı");
            player.Health = player.Health- 5;
            healthBar.value = player.Health;
            Debug.Log("Can: " + player.Health);
        
        }
        if (collision.gameObject.CompareTag("bigDamage")) 
        { player.Health = player.Health- 10; }

        
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("areaDamage"))
        { health = 0; }
        if (collision.gameObject.CompareTag("charger"))
        { health = player.Health + 2f; }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 0.2f;
            Debug.Log("Hasar alındı");
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("areaDamage"))
        { health = 0; }
        if (collision.gameObject.CompareTag("charger"))
        { health = player.Health + 2f; }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 0.2f;
            Debug.Log("Hasar alındı");
        }

    }
    //Burada lav gibi bir şey olursa dokunduğu sürece can kaybedebilir.
    //Tekrar can toplasın diye şarj olduğu yerler eklenebilir diye düşündüm.
}
