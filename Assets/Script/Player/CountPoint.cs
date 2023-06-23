using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CountPoint : MonoBehaviour
{
    SpriteRenderer player;

    private void Awake()
    {
        player = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            if (player.sprite == collision.GetComponent<SpriteRenderer>().sprite 
                || player.color == collision.GetComponent<SpriteRenderer>().color)
            {
                CountingPoint.instance.onCountingPoint(1);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
