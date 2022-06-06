using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElavatorControl : MonoBehaviour
{
    Vector3 startPos;
    [SerializeField] Vector3 endPos;
    [SerializeField] GameObject FTusu;
    public Transform player;

    bool fControl;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        FTusu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ElevatorPos();
    }

    void ElevatorPos()
    {
        if(fControl && Input.GetKeyDown(KeyCode.F))
        {

            if(transform.position == startPos)
            {
                transform.position = endPos;
                player.position = new Vector3(endPos.x, endPos.y + 0.8f, player.position.z);
                fControl = false;
            }
            else if(transform.position == endPos)
            {
                transform.position = startPos;
                player.position = new Vector3(startPos.x, startPos.y + 0.8f, player.position.z);
                fControl = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FTusu.SetActive(true);
        if (collision.gameObject.CompareTag("Player"))
        {
            fControl = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        FTusu.SetActive(false);
        if (collision.gameObject.CompareTag("Player"))
        {
            fControl = false;
        }
    }

}
