using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject objExplosion, objRestart;
    public static bool lose = false;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            lose = true;
            Instantiate(objExplosion, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
            Instantiate(objRestart, new Vector3(objRestart.transform.position.x, objRestart.transform.position.y, 0), Quaternion.identity);
            //Destroy(gameObject);
        }
    }
}
