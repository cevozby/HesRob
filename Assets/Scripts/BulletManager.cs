using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    
    public Transform muzzle;
    public Transform leftMuzzle;
    public GameObject bullet;
    float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        timeCount = 1f;
        //StartCoroutine(BulletCreate());
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCount >= -1f)
        {
            timeCount -= Time.deltaTime;
        }
        
        if (timeCount <=0f)
        {
            Target();
            
            
        }
        
        
    }

    void Target()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(!PlayerController.left)
            {
                Instantiate(bullet, muzzle.position, Quaternion.identity);
            }    
            else if (PlayerController.left)
            {
                Instantiate(bullet, leftMuzzle.position, Quaternion.identity);
            }
            if (timeCount <= 0f)
            {
                timeCount = 1f;
            }
        }
        
    }

    IEnumerator BulletCreate()
    {
        
        

        yield return new WaitForSeconds(1f);
    }

}
