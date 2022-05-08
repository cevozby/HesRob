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
    
     public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("smallDamage")) 
        { playerHealth = playerHealth- 5; }
        if (collision.gameObject.CompareTag("bigDamage")) 
        { playerHealth = playerHealth- 10; }
    }


    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("areaDamage")) 
        { playerHealth = playerHealth - 2; }
        if (collision.gameObject.CompareTag("charger")) 
        { playerHealth = playerHealth + 8; }
    }
    //Burada lav gibi bir şey olursa dokunduğu sürece can kaybedebilir.
    //Tekrar can toplasın diye şarj olduğu yerler eklenebilir diye düşündüm.
}
