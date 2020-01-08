using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=0T5ei9jN63M code from here going to be slightly altered for my use
public class HealthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;
    private int healthMax;
    void Start()
    {

    }

    // Update is called once per frame
    public HealthSystem(int health)
    {
        this.health = health;
        health = healthMax;
    }

    public int GetHealth()
    {
        return health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;
    }
    public void Heal(int healAmount)
    {
        health += healAmount;
        if ( health > healthMax) health = healthMax; 
    }


}

