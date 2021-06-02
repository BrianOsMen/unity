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
    }

    void Damage()
    {
        healt -= 25;
    }

    private void OnTriggerStay()
    {
        isTrigger = true;
        Debug.Log(isTrigger);
    }

    private void OnTriggerExit()
    {
        isTrigger = false;
        Debug.Log(isTrigger);
    }

}
