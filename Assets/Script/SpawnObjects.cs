using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] Objects;
    public GameObject RandBlock;
    public Vector2 Rand;
    public float ran;
    public void Start()
    {
        StartCoroutine(Spawn(1));
    }
    IEnumerator Spawn(float seconds)
    {
        Rand = new Vector2(Random.Range(-2f, 2f), transform.position.y);
        yield return new WaitForSeconds(Random.Range(2f, seconds));
        RandBlock = Objects[Random.Range(0, Objects.Length)];
        Instantiate(RandBlock, Rand, transform.rotation);
        StartCoroutine(Spawn(0.5f));
    }
}
