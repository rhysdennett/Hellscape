using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portals : MonoBehaviour
{
    GameObject p;
    Transform ani;
    Player pS;
    public Transform goTo;
    public bool teleport;
    public bool cgr, cgl, cgu, cgd;
    int t;
    void Start()
    {
        p = GameObject.Find("player");
        pS = p.GetComponent<Player>();
        ani = GameObject.Find("Animation").GetComponent<Transform>();
        teleport = true;
        t = 0;
    }
    //private void OnCollisionEnter2D(Collision2D collisionInfo)
    //{
    //    if (teleport && collisionInfo.collider.name == "player")
    //    {
    //        goTo.GetComponent<portals>().teleport = false;
    //        p.transform.position = goTo.position;
    //    }
    //}
    void Update()
    {
        if (pS.state == "restart") t = 0;
        if (transform.position == p.transform.position)
        {
            pS.cgr = cgr;
            pS.cgl = cgl;
            pS.cgu = cgu;
            pS.cgd = cgd;
            if (teleport)
            {
                pS.state = "animation";
            }
        }
        else teleport = true;
        if(pS.state == "animation" && transform.position==p.transform.position)
        {
            if (t == 0)
            {
                ani.localScale = new Vector3(0.0001f, 0.0001f);
                ani.position = p.transform.position;
            }
            t++;
            if (ani.localScale.x >= 1.2f)
            {
                goTo.GetComponent<portals>().teleport = false;
                p.transform.position = goTo.position;
                ani.position = new Vector3(-20, 20);
                t = 0;
                pS.state = "two";
                ani.localScale = new Vector3(0.0001f, 0.0001f);
            }
            ani.localScale += new Vector3(0.04f, 0.04f);
            
        }
    }
}
