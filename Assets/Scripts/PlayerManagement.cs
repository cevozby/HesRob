using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagement : MonoBehaviour
{
    public static int playerHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        
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
