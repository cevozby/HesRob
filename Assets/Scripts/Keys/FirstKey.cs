using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKey : MonoBehaviour
{
    public GameObject lockedBox, openedBox, emptyBox;
    bool fCheck, openCheck, emptyCheck;
    public static bool keyControl;
    [SerializeField] GameObject FTusu;

    // Start is called before the first frame update
    void Start()
    {
        openCheck = false;
        emptyCheck = false;
        keyControl = false;
        FTusu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OpenBox();
        TakeKey();
    }

    void OpenBox()
    {
        if(fCheck && !openCheck && Input.GetKeyDown(KeyCode.F))
        {
            lockedBox.SetActive(false);
            openedBox.SetActive(true);
            openCheck = true;
        }
    }

    void TakeKey()
    {
        if(fCheck && openCheck && !keyControl && Input.GetKeyDown(KeyCode.F))
        {
            openedBox.SetActive(false);
            emptyBox.SetActive(true);
            keyControl = true;
            fCheck = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && Anahtar.anahtarCheck)
        {
            FTusu.SetActive(true);
            fCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FTusu.SetActive(false);
            fCheck = false;
        }
    }

}
