using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_LVL_Update : MonoBehaviour
{
    public Transform[] Blocks;

    private int completeLevels = 0; //уровень

    public void Start() //запуск генерации уровня при старте
    { 
        StartCoroutine(OnGeneratingRoutine()); 
    } 

    private IEnumerator OnGeneratingRoutine()//генерация уровня
    {
        Vector2 size = new Vector2(1, 1);
        Vector2 position = new Vector2(-20, 0);


        for (int i = 0; i < 10; i++) //Начальные блоки ровные
        {
            position.x += size.x + 4f;
            //position.y += size.y * Random.Range(-1, 2);
            Instantiate(Blocks[Random.Range(0, Blocks.Length)], position, Quaternion.identity);
        }

        int count = this.completeLevels + 500;

        for (int i = 0; i < count; i++)
        {
            position.x += size.x + 4f;
            position.y += size.y * Random.Range(-1, 2);
            Instantiate(Blocks[Random.Range(0, Blocks.Length)], position, Quaternion.identity);
        }

        yield return new WaitForEndOfFrame();
    } 

    public void CompleteLevel()
    {
        this.completeLevels += 1;
    }

}

 