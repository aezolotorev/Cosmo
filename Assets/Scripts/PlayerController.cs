using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public PlayerInput playerInput;
    public PlayerProperties playerproperties;
    public SpriteRenderer spriterenderer;
    public float speed;
    public float jumpSpeed;
    public PlayerAnimations playerAnimations;
    public Rigidbody2D rigid;
    


    private void Awake()
    {

        playerInput = GetComponent<PlayerInput>();
        playerproperties.dir = 1;
        spriterenderer = GetComponent<SpriteRenderer>();
        playerAnimations = GetComponent<PlayerAnimations>();
        rigid = GetComponent<Rigidbody2D>();
        playerproperties.isMoving = false;
        playerproperties.isJump = false;
       
    }

    void Start()
    {

    }


    void Update()
    {
        Move();
        playerAnimations.AnimationUpdate();
    }

    private void Move()
    {
        if (playerInput.ForwardBackward > 0 && playerproperties.dir == 1)
        {

            transform.Translate(new Vector2(Time.deltaTime * playerproperties.speed * playerproperties.dir, 0));
            playerproperties.isMoving = true;
        }
        if (playerInput.ForwardBackward < 0 && playerproperties.dir == -1)
        {

            transform.Translate(new Vector2(Time.deltaTime * playerproperties.speed * playerproperties.dir, 0));
            playerproperties.isMoving = true;
        }
        if (playerInput.ForwardBackward == 0)
        {
            playerproperties.isMoving = false;
            playerproperties.isStop = true;
        }

        if (playerInput.ForwardBackward < 0 && playerproperties.dir == 1)
        {

            playerproperties.dir = -1;
            spriterenderer.flipX = true;
            playerproperties.isMoving = false;

        }
        if (playerInput.ForwardBackward > 0 && playerproperties.dir == -1)
        {

            playerproperties.dir = 1;
            spriterenderer.flipX = false;
            playerproperties.isMoving = false;

        }
        if (playerInput.Jump && playerproperties.isGround)
        {
            playerproperties.isJump = true;
            rigid.AddForce(Vector2.up * playerproperties.jumpSpeed, ForceMode2D.Impulse);

        }
    }
   
 

}
