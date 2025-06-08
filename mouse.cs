using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public GameObject mouse1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse1.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(.1f, -.5f, 10);
    }
}
