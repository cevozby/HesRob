using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondKey : MonoBehaviour
{
    public GameObject key;
    bool fCheck;
    public static bool keyControl;

    // Start is called before the first frame update
    void Start()
    {
        keyControl = false;
    }

    // Update is called once per frame
    void Update()
    {
        TakeKey();
    }

    

    void TakeKey()
    {
        if (fCheck && !keyControl && Input.GetKeyDown(KeyCode.F))
        {
            key.SetActive(false);
            keyControl = true;
            fCheck = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !keyControl)
        {
            fCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fCheck = false;
        }
    }
}
