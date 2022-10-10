using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler2 : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    float maxspeed = 20.0f;
    bool isOnGround = false;

    Rigidbody2D playerObject;

    Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        float movementValueX = 5.0f;
        Animator anim;

        anim = GetComponent<Animator>();

        anim.SetFloat("Speed", Mathf.Abs(movementValueX));
        anim.SetBool("IsOnGround", isOnGround);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxspeed = 40.0f;

        } else
        {
            maxspeed = 20.0f;

        }

      

        


        playerObject.velocity = new Vector2(movementValueX, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, 500f));
        }
    }
}
