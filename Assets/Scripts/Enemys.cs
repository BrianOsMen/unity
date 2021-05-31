using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{

    public bool isEnemy;
    public int enemyClass;
    public string consonants = "BCDFGHJKLMNPQRSTVWXYZ";
    public string vowels = "AEIOU";

    // Start is called before the first frame update
    void Start()
    {
        isEnemy = true;
    }
}
