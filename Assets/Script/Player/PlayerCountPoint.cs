using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCountPoint : MonoBehaviour
{
    [SerializeField] SpriteRenderer player;
    [SerializeField] SpriteRenderer enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")&& player.sprite == enemy.sprite || player.color == enemy.color)
        {
            Destroy(collision.GameObject());
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
