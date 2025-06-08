using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform player;
    public bool moveX, moveY;
    public float speedX, speedY;
    Vector3 ip;

    float forVerticalFall;
    void Start()
    {
        player = GameObject.Find("player").GetComponent<Transform>();
        speedX = 0.02f;
        speedY = 0.02f;
        ip = transform.position;
    }
    void Update()
    {
        if (player.GetComponent<Player>().state == "restart")
        {
            print("camera check");
            moveX = false; moveY = false;
            transform.position = ip;
        }

        if (player.GetComponent<Player>().state == "one")
        {
            if ((player.position.x - transform.position.x) > 5f || (player.position.x - transform.position.x) < -5f) speedX = 0.5f;
            else if ((player.position.x - transform.position.x) > 4f || (player.position.x - transform.position.x) < -4f) speedX = 0.3f;
            else if ((player.position.x - transform.position.x) > 2.5f || (player.position.x - transform.position.x) < -2.5f) speedX = 0.2f;
            else speedX = 0.1f;


            if ((player.position.y - transform.position.y) > 5f || (player.position.y - transform.position.y) < -5f) speedY = 0.4f;


            else if ((player.position.y - transform.position.y) > 4f || (player.position.y - transform.position.y) < -4f) speedY = 0.3f;
            else if ((player.position.y - transform.position.y) > 1f || (player.position.y - transform.position.y) < -1f) speedY = 0.2f;
            else speedY = 0.1f;


            if ((player.position.x - transform.position.x) > 1f || (player.position.x - transform.position.x) < -1f) moveX = true;
            if ((player.position.y - transform.position.y) > 0.5f || (player.position.y - transform.position.y) < -0.5f) moveY = true;
            if (moveX)
            {
                if (player.transform.position.x > transform.position.x)
                {
                    transform.position += new Vector3(speedX, 0);
                    if (player.transform.position.x <= transform.position.x) moveX = false;
                }
                if (player.transform.position.x < transform.position.x)
                {
                    transform.position -= new Vector3(speedX, 0);
                    if (player.transform.position.x >= transform.position.x) moveX = false;
                }
            }
            if (moveY)
            {
                if (player.transform.position.y > transform.position.y)
                {
                    transform.position += new Vector3(0, speedY, 0);
                    if (player.transform.position.y <= transform.position.y) moveY = false;
                }
                if (player.transform.position.y < transform.position.y)
                {
                    transform.position -= new Vector3(0, speedY, 0);
                    if (player.transform.position.y >= transform.position.y) moveY = false;
                }
            }
        }



        if (player.GetComponent<Player>().state == "two")
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }
    }
}
