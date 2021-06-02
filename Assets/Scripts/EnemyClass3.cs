using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass3 : Enemys

{
    // Start is called before the first frame update
    void Start()
    {
        isEnemy = true;
        enemyClass = 3;
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
            int l = Random.Range(0, 4);
            if (l == i)
            {
                theChar = consonants[Random.Range(0, consonants.Length)];
                atackString += theChar;
            }
            else
            {
                theChar = vowels[Random.Range(0, vowels.Length)];
                atackString += theChar;
            }
        }
        return atackString;
    }

}
