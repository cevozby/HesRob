using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevel : MonoBehaviour
{
    public GameObject door;
    bool fCheck, doorOpen;
    public static bool secondLevelCheck;
    [SerializeField] GameObject FTusu;

    // Start is called before the first frame update
    void Start()
    {
        fCheck = false;
        secondLevelCheck = false;
        FTusu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
        if (doorOpen)
        {
            StartCoroutine(DoorMovement());
        }
    }

    void OpenDoor()
    {
        if (fCheck && FirstKey.keyControl && Input.GetKeyDown(KeyCode.F))
        {
            doorOpen = true;
            secondLevelCheck = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
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

    IEnumerator DoorMovement()
    {
        door.transform.Translate(Vector3.up * Time.deltaTime * -5f);
        yield return new WaitForSeconds(3.5f);
        door.SetActive(false);
    }
}
