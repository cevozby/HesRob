using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManagement : MonoBehaviour
{
    Robot player = new Robot(100, 10, 15);

    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.minValue = 0;
        healthBar.maxValue = player.Health;
        healthBar.value = player.Health;
        Debug.Log(player.Health);
        Debug.Log(player.DamageGenerate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
