using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirthDoor : MonoBehaviour
{
    public GameObject switchPanel;
    bool fCheck;
    public static bool whiteDoorCheck;
    [SerializeField] GameObject FTusu;

    // Start is called before the first frame update
    void Start()
    {
        whiteDoorCheck = false;
        FTusu.SetActive(false);
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
            //SceneManager.LoadScene("calculator2");
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
}
