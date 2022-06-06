using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteDoor : MonoBehaviour
{
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    void OpenDoor()
    {
        if (ThirthDoor.whiteDoorCheck)
        {
            StartCoroutine(DoorMovement());
        }
    }

    



    IEnumerator DoorMovement()
    {
        door.transform.Translate(Vector3.up * Time.deltaTime * -5f);
        yield return new WaitForSeconds(3.5f);
        door.SetActive(false);
    }
}
