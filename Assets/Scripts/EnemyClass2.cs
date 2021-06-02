using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass2 : Enemys
{
    // Start is called before the first frame update
    void Start()
    {
        isEnemy = true;
        enemyClass = 2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player1")
        {
            Debug.Log(Atack());
        }
    }

    private string Atack()
    {
        char theChar;
        string atackString = "";
        for (int i = 0; i < 5; i++)
        {
            theChar = vowels[Random.Range(0, vowels.Length)];
            atackString += theChar;
        }
        return atackString;
    }
}
