using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    GameObject player;
    int damage;
    Healthbar healthbar;

    void Start()
    {
        player = GameObject.Find("player");
        healthbar = GameObject.Find("slider").GetComponent<Healthbar>();
        damage = 1;
    }
    void Update()
    {
        //plant damage
        if (player.GetComponent<SpriteRenderer>().bounds.Intersects(GetComponent<SpriteRenderer>().bounds))
        {
            healthbar.currenthealth -= damage;

            healthbar.SetHealth(healthbar.currenthealth);
        }

    }
   
}
