using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed_Player; //Скорость игрока текущая
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 3.56f);
        speed_Player = GlobalSpeed.Speed;
        rb.velocity = new Vector2(rb.velocity.x, -speed_Player);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeadCollider")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Script_Player.Score += 50f;
        }
    }
}
