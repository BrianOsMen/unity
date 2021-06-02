using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{

    public bool isEnemy;
    public bool isTrigger;
    public int enemyClass;
    public string consonants = "BCDFGHJKLMNPQRSTVWXYZ";
    public string vowels = "AEIOU";
    public int healt = 100;

    // Start is called before the first frame update
    void Start()
    {
        isEnemy = true;
    }

    void Damage()
    {
        healt -= 25;
    }

    private void OnTriggerStay()
    {
        isTrigger = true;
    }

    private void OnTriggerExit()
    {
        isTrigger = false;
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
        string atackString = "";
        char theChar;
        if(enemyClass == 1)
        {
            for(int i = 0; i < 5; i++)
            {
                theChar = consonants[Random.Range(0, consonants.Length)];
                atackString += theChar;
            }
        }
        if(enemyClass == 2)
        {
            for(int i = 0; i < 5; i++)
            {
                theChar = vowels[Random.Range(0, vowels.Length)];
                atackString += theChar;
            }
        }
        if(enemyClass == 3)
        {
            int l = Random.Range(0, 4);
            for(int i = 0; i < 5; i++)
            {
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
        }
        return atackString;
    }



}
