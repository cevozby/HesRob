using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabloPaneli : MonoBehaviour
{
    public GameObject tamirli;
    bool fCheck;
    public static bool sariAsansor;

    // Start is called before the first frame update
    void Start()
    {
        sariAsansor = false;
    }

    // Update is called once per frame
    void Update()
    {
        Kontrol();
    }

    void Kontrol()
    {
        if(fCheck && Input.GetKeyDown(KeyCode.F))
        {
            tamirli.SetActive(true);
            sariAsansor = true;
            fCheck = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
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
