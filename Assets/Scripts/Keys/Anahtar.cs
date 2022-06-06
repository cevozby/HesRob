using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anahtar : MonoBehaviour
{
    public GameObject anahtar;
    bool fChechk;
    public static bool anahtarCheck;

    // Start is called before the first frame update
    void Start()
    {
        anahtarCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        TakeKey();
    }

    void TakeKey()
    {
        if(fChechk && Input.GetKeyDown(KeyCode.F))
        {
            anahtar.SetActive(false);
            anahtarCheck = true;
            fChechk = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fChechk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fChechk = false;
        }
    }

}
