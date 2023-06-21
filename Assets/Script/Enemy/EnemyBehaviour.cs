using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] ChangeCharacter change;
    [SerializeField] Rigidbody2D erb;
    GameObject player;
    float espeed;

    private void Start()
    {
        player = GameObject.Find("Player");
        espeed = Random.Range(0.5f, 2f);
        StartCoroutine(change.ChangeChar());
        StartCoroutine(change.ColorChar());
    }
    private void Update()
    {
        FollowPlayer();
    }
    void FollowPlayer()
    {
        if(player != null)
        {
            var direction = (player.transform.position - transform.position).normalized;
            erb.velocity = new Vector3(direction.x, direction.y,0f)*espeed;
        }
    }
}
