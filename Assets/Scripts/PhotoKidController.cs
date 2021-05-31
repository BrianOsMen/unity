using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoKidController : MonoBehaviour
{
    private Enemys c;
    public CharacterController player;
    public float horizontalMove;
    public float verticalMove;
    private Vector3 playerInput;


    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        player.transform.LookAt(player.transform.position + playerInput);

        player.Move(playerInput * playerSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        c = other.GetComponent<Enemys>();
        if(c != null)
            Debug.Log(c.enemyClass);
    }

}
