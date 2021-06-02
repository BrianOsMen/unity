using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoKidAtack : PhotoKidController
{
    
    private Enemys d;
    private bool atackFalt;
    // Start is called before the first frame update
    void Start()
    {
        atackFalt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(d != null && !atackFalt)
        {
            Debug.Log(d.name + " bajo ataque");
            atackFalt = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        d = other.GetComponent<Enemys>();
    }

    private void OnTriggerExit()
    {
        d = null;
        atackFalt = false;
    }

    private void AtackEnemy()
    {
    }

}
