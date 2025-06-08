using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}
