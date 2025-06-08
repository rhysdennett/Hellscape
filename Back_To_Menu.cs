using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_To_Menu : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(4);
    }
}
