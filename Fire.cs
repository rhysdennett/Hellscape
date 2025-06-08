using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{

    public GameObject fire;
    GameObject player;
    Healthbar healthbar;

    public GameObject goal;

    void Start()
    {
        player = GameObject.Find("player");
        healthbar = GameObject.Find("slider").GetComponent<Healthbar>();
    }


    public void Update()
    {
        //fire damage


        //player goes to 3rd scene
        if (player.GetComponent<SpriteRenderer>().bounds.Intersects(goal.GetComponent<SpriteRenderer>().bounds))
        {
            SceneManager.LoadScene("scene_3");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            healthbar.takedamage(1);

        }

    }


}
