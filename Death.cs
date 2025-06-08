using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    GameObject player;
    int damage;
    Healthbar healthbar;
    public GameObject topborder;
    public GameObject downborder;
    public GameObject acidpart3;
    public GameObject acidpart4;
    public GameObject acidpart5;
    public GameObject acidpart6;
    Animator animator;

    void Start()
    {
        player = GameObject.Find("player");
        healthbar = GameObject.Find("slider").GetComponent<Healthbar>();
        damage = 2;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        try
        {

            if (player.GetComponent<SpriteRenderer>().bounds.Intersects(GetComponent<SpriteRenderer>().bounds))
            {
                healthbar.currenthealth -= damage;

                healthbar.SetHealth(healthbar.currenthealth);

                animator.SetBool("isHit", true);
            }
            if (player.GetComponent<SpriteRenderer>().bounds.Intersects(topborder.GetComponent<SpriteRenderer>().bounds))
            {
                healthbar.currenthealth -= damage;

                healthbar.SetHealth(healthbar.currenthealth);

                animator.SetBool("isHit", true);
            }
            if (player.GetComponent<SpriteRenderer>().bounds.Intersects(downborder.GetComponent<SpriteRenderer>().bounds))
            {
                healthbar.currenthealth -= damage;

                healthbar.SetHealth(healthbar.currenthealth);

                animator.SetBool("isHit", true);
            }
            if (player.GetComponent<SpriteRenderer>().bounds.Intersects(acidpart3.GetComponent<SpriteRenderer>().bounds))
            {
                healthbar.currenthealth -= damage;

                healthbar.SetHealth(healthbar.currenthealth);

                animator.SetBool("isHit", true);
            }
            if (player.GetComponent<SpriteRenderer>().bounds.Intersects(acidpart4.GetComponent<SpriteRenderer>().bounds))
            {
                healthbar.currenthealth -= damage;

                healthbar.SetHealth(healthbar.currenthealth);

                animator.SetBool("isHit", true);
            }
            if (player.GetComponent<SpriteRenderer>().bounds.Intersects(acidpart5.GetComponent<SpriteRenderer>().bounds))
            {
                healthbar.currenthealth -= damage;

                healthbar.SetHealth(healthbar.currenthealth);

                animator.SetBool("isHit", true);
            }
            if (player.GetComponent<SpriteRenderer>().bounds.Intersects(acidpart6.GetComponent<SpriteRenderer>().bounds))
            {
                healthbar.currenthealth -= damage;

                healthbar.SetHealth(healthbar.currenthealth);

                animator.SetBool("isHit", true);
            }
        } catch (UnityEngine.MissingComponentException e)
        {
            Debug.LogWarning(e);
        }

    }
}
