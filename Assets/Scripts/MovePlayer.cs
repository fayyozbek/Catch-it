using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed= 10f;
    private void OnMouseDrag()
    {   //Screen.w
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.2f ? 2.2f : mousePos.x;
            mousePos.x = mousePos.x < -2.2f ? -2.2f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);
        }
    }

}
