using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour
{
    public bool go;
    Vector3 ip;
    Player p;
    void Start()
    {
        go = false;
        ip = transform.position;
        p = GameObject.Find("player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(p.state == "restart")
        {
            transform.position = ip;
            go = false;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        if (go && transform.position.y < 20) GetComponent<Rigidbody2D>().velocity = new Vector3(0, 6);
    }
}
