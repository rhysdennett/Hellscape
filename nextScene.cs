using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene1 : MonoBehaviour
{
    SpriteRenderer player;
    void Start()
    {
        player = GameObject.Find("player").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.bounds.Intersects(GetComponent<SpriteRenderer>().bounds))
        {
            SceneManager.LoadScene("Scene_2");
        }
    }
}
