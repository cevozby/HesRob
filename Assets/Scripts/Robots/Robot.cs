using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    int health;
    int damage;

    int minValue;
    int maxValue;

    int defance;

    int critRate, minRate,maxRate;
    int critDamage;

    public Robot(int health, int minValue, int maxValue)
    {
        this.health = health;
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    public int Health { get => health; set => health = value; }

    /*public int Damage 
    { 
        get => damage;
        set
        {
            damage = Random.RandomRange(minValue, maxValue);
        }
    }*/

    public int DamageGenerate()
    {
        return damage = Random.Range(minValue, maxValue);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
