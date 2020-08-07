using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    private void Start()
    {
        StartCoroutine(Spawn());   
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);


            yield return new WaitForSeconds(2.5f);
        }
    }
}
