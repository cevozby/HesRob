using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabloPaneli : MonoBehaviour
{
    public GameObject tamirli;
    bool fCheck;
    public static bool sariAsansor;
    [SerializeField] GameObject FTusu;

    // Start is called before the first frame update
    void Start()
    {
        sariAsansor = false;
        FTusu.SetActive(false);
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
        FTusu.SetActive(true);
        if (collision.gameObject.CompareTag("Player"))
        {
            fCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        FTusu.SetActive(false);
        if (collision.gameObject.CompareTag("Player"))
        {
            fCheck = false;
        }
    }


}
