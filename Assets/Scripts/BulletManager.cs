using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    
    public Transform muzzle;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Target();
    }

    void Target()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(BulletCreate());
        }
    }

    IEnumerator BulletCreate()
    {
        Instantiate(bullet, muzzle.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
    }

}
