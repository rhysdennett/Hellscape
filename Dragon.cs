using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    
    public GameObject brick1;
    public GameObject brick2;

    public GameObject fire;

    public float bricktimer;
    public float brickspawninterval = 6f;
    public float firespawninterval = 10f;


    float speed = 0.1f;

    Vector3 fireInitialPosition, farAway;
    public Vector3 pposition;
    Vector3 brickpos, away;
    Vector3 brickpos2, away2;
    void Start()
    {
        Application.targetFrameRate = 60;
        brick1.GetComponent<SpriteRenderer>().enabled = false;
        brick2.GetComponent<SpriteRenderer>().enabled = false;
        fireInitialPosition = fire.transform.position;
        //bricks
        brickpos = brick1.transform.position;
        brickpos2 = brick1.transform.position;
        farAway = new Vector3(0,50,0);
    }


    void Update()
    {


        bricktimer += Time.deltaTime;

        //when time is 3, bricks go down
        if(bricktimer > 3f)
        {
            //1
            brick1.GetComponent<SpriteRenderer>().enabled = true;
            brick1.transform.position -= new Vector3(0, +speed, 0);
            fire.transform.position = farAway;
        }
        if(bricktimer > 4)
        {
            //2
            brick2.GetComponent<SpriteRenderer>().enabled = true;
            brick2.transform.position -= new Vector3(0, +speed, 0);
        }

        //when time reaches 6, brick positions get reset
        if (bricktimer > brickspawninterval)
        {
            fire.transform.position = fireInitialPosition;
            //fire.transform.position = new Vector3(10.7f, 0.7f, 0);
            //1
            brickpos = brick1.transform.position; //resets position of brick
            brick1.GetComponent<SpriteRenderer>().enabled = false;
            //2
            brickpos2 = brick1.transform.position;
            brick2.GetComponent<SpriteRenderer>().enabled = false;

            bricktimer = 0;
        }

        //makes them invisible after they pass the platform
        if(brick1.transform.position.y <= -3)
        {
            brick1.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (brick2.transform.position.y <= -3)
        {
            brick2.GetComponent<SpriteRenderer>().enabled = false;
        }



    }
    
    
        
    

}
