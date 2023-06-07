using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float speed;
    public Vector3 Move;
    public GameObject GameObj;
    void Start()
    {
        Move = Touch.TouchPos;
        
    }
    void Update()
    {
        if (transform.position.x == Move.x && transform.position.y == Move.y)
        {
            Destroy(gameObject);
        }
        GameObj.transform.position = Vector2.MoveTowards(transform.position, Move, speed);
        transform.position = new Vector3(transform.position.x, transform.position.y, 1f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
