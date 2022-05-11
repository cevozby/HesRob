using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManagement : MonoBehaviour
{
    Robot player = new Robot(100, 10, 15);

    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.minValue = 0;
        healthBar.maxValue = player.Health;
        healthBar.value = player.Health;
        Debug.Log(player.Health);
        Debug.Log(player.DamageGenerate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("smallDamage")) 
        {
            Debug.Log("Hasar ALındı");
            player.Health = player.Health- 5;
            healthBar.value = player.Health;
            Debug.Log("Can: " + player.Health);
        
        }
        if (collision.gameObject.CompareTag("bigDamage")) 
        { player.Health = player.Health- 10; }
    }

    
    private void OnTiggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("areaDamage")) 
        { player.Health = player.Health - 2; }
        if (collision.gameObject.CompareTag("charger")) 
        { player.Health = player.Health + 8; }
    }
    //Burada lav gibi bir şey olursa dokunduğu sürece can kaybedebilir.
    //Tekrar can toplasın diye şarj olduğu yerler eklenebilir diye düşündüm.
}
