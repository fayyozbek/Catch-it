using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MoveBomb : MonoBehaviour
{
    public TextMeshProUGUI txt;

    public float speed = 2f;
    
    private void Start()
    {
        
       // count = Int32.Parse(txt.text);
    }
    void Update()
    {
        if (!Player.lose)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);

            if (transform.position.y < -4.6f)
            {
                Counter.count += 1;
                
                Destroy(gameObject);
            }
        }
    }
}
