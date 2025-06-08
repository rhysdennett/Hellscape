using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Select : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(5);
    }
}
