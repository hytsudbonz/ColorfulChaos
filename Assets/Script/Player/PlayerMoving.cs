using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float speedMove;
    Vector2 movement;

    private void Update()
    {
         MoveByKey();
         //MoveByMouse();
    }
    void MoveByMouse()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        if(pos.y > 4.5f)
        {
            pos.y = 4.5f;
        }
        if(pos.y < -4.5f)
        {
            pos.y = -4.5f;
        }
        if(pos.x > 10.65f)
        {
            pos.x = 10.65f;
        }
        if(pos.x < -10.65f)
        {
            pos.x = -10.65f;
        }
        transform.position = pos;
    }
    void MoveByKey()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        rb.velocity = movement * speedMove * Time.deltaTime;
    }
}
