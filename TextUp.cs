using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().sortingOrder = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
