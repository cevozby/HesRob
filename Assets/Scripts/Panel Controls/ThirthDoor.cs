using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirthDoor : MonoBehaviour
{
    public GameObject switchPanel;
    bool fCheck;
    public static bool whiteDoorCheck;

    // Start is called before the first frame update
    void Start()
    {
        whiteDoorCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        Kontrol();
    }

    void Kontrol()
    {
        if (fCheck && Input.GetKeyDown(KeyCode.F))
        {
            switchPanel.SetActive(true);
            whiteDoorCheck = true;
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
