using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdDoor : MonoBehaviour
{
    public GameObject door;
    bool fCheck;
    public static bool thirdLevelCheck;

    // Start is called before the first frame update
    void Start()
    {
        fCheck = false;
        thirdLevelCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    void OpenDoor()
    {
        if (fCheck && FirstKey.keyControl && Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(DoorMovement());
            thirdLevelCheck = true;
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
        door.transform.Translate(Vector3.up * Time.deltaTime * 1.15f);
        yield return new WaitForSeconds(3.5f);
        door.SetActive(false);
    }
}
