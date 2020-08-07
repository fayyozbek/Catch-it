using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Start : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("main");
        Player.lose = false;
    }
}
