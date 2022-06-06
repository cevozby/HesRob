using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoor : MonoBehaviour
{
    public GameObject door;
    bool fCheck, doorOpen;
    public static bool firstLevelCheck;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        fCheck = false;
        doorOpen = false;
        firstLevelCheck = false;
        speed = 1.15f;
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
        if(fCheck && FirstKey.keyControl && Input.GetKeyDown(KeyCode.F))
        {
            doorOpen = true;
            firstLevelCheck = true;
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

    IEnumerator DoorMovement()
    {
        door.transform.Translate(Vector3.up * Time.deltaTime * speed);
        yield return new WaitForSeconds(3.5f);
        door.SetActive(false);
    }

}
