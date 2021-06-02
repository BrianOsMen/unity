using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyClass1 : Enemys
{
    // Start is called before the first frame update
    void Start()
    {
        isEnemy = true;
        enemyClass = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player1")
        {
            Debug.Log(Atack());
        }
    }

    private string Atack()
    {
        string atackString = "";
        for(int i = 0; i < 5; i++)
        {
            char theChar = consonants[Random.Range(0, consonants.Length)];
            atackString += theChar;
        }
        return atackString;
    }

}
