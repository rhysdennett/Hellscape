using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Transform firstPortal, lastPortal, firstPortal2, lastPortal2, switchE, switchE2, switchE3, switchE4, switchE5;
    public float speed;
    up one;
    public int lo, lastLo;
    public string state;
    public float x, y;
    public bool cgr, cgl, cgu, cgd, s1, s2, s3, s4, s5;
    Vector3 ip;
    Animator animator;

    Rigidbody2D rb;
    public GameObject goal1;
    Healthbar healthbar;

    void Start()
    {
        Application.targetFrameRate = 60;
        lo = 36;
        lastLo = 45;
        speed = 0.05f;
        healthbar = GameObject.Find("slider").GetComponent<Healthbar>();
        state = "one";
        s1 = true; s2 = true; s3 = true; s4 = true; s5 = true;
        ip = transform.position;
        animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //TEST
        print("block (" + lo + ")");


        //RESTART
        if (state == "restart")
        {
            transform.position = ip;
            x = 0; y = 0;
            lo = 36;
            lastLo = 45;
            speed = 0.05f;
            rb.bodyType = RigidbodyType2D.Dynamic;
            state = "one";
            s1 = true; s2 = true; s3 = true; s4 = true; s5 = true;
            healthbar.SetHealth(healthbar.maxhealth);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            state = "restart";
        }


        if (state == "one")
        {
            if (Input.GetKey(KeyCode.D) && x < 7f)
            {
                if (x < 2) x += 0.5f;
                x += speed;
            }
            else if (x > 0) x -= speed;
            if (Input.GetKey(KeyCode.A) && x > -7f)
            {
                if (x > -2) x -= 0.5f;
                x -= speed;
            }
            else if (x < 0) x += speed;
            rb.velocity = new Vector3(x, y);

            if (transform.position.x > (firstPortal.position.x - 0.5f) && transform.position.x <= firstPortal.position.x)
            {
                rb.velocity = new Vector3(0, 0);
                transform.position = firstPortal.position;
                rb.bodyType = RigidbodyType2D.Static;
            }
            if (transform.position.x > (firstPortal2.position.x - 0.5f) && transform.position.x <= firstPortal2.position.x)
            {
                rb.velocity = new Vector3(0, 0);
                transform.position = firstPortal2.position;
                rb.bodyType = RigidbodyType2D.Static;
            }

            if (transform.position.x >= switchE.position.x - 0.2f && s1) { lo = 136; lastLo = 151; s1 = false; }
            if (transform.position.x >= switchE2.position.x - 0.2f && s2) { lo = 192; lastLo = 196; s2 = false; }
            if (transform.position.x >= switchE3.position.x - 0.2f && s3) { lo = 198; lastLo = 202; s3 = false; }
            if (transform.position.x >= switchE4.position.x - 0.2f && s4) { lo = 204; lastLo = 208; s4 = false; }
            if (transform.position.x >= switchE5.position.x - 0.2f && s5) { lo = 210; lastLo = 212; s5 = false; }

        }
        if (animator)
        {
            animator.SetFloat("Speed", rb.velocity.magnitude);

        }
        //ACTIVITY 1
        if (Input.GetKeyDown(KeyCode.E) && lo < lastLo)
        {
            one = GameObject.Find("block (" + lo + ")").GetComponent<up>();
            one.go = true;
            lo++;
            animator.SetBool("E", true);
        }

        //FLIPSPRITE
        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        //ACTIVITY 2
        if (state == "two")
        {
            if (Input.GetKeyDown(KeyCode.D) && cgr) transform.position += new Vector3(1, 0);
            if (Input.GetKeyDown(KeyCode.A) && cgl) transform.position -= new Vector3(1, 0);
            if (Input.GetKeyDown(KeyCode.W) && cgu) transform.position += new Vector3(0, 1, 0);
            if (Input.GetKeyDown(KeyCode.S) && cgd) transform.position -= new Vector3(0, 1, 0);
            if ((transform.position == lastPortal.position && lastPortal.GetComponent<portals>().teleport == false) || (transform.position == lastPortal2.position && lastPortal2.GetComponent<portals>().teleport == false))
            {
                state = "one";
                rb.bodyType = RigidbodyType2D.Dynamic;
                y = 0; x = 2;
            }
        }


    }
}
