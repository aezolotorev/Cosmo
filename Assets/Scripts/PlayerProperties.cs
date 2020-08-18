using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Player/properties")]
public class PlayerProperties : ScriptableObject
{
    public float speed;
    public float jumpSpeed;
    public float maxHealth;
    public bool isGround=false;
    public bool isFlying;
    public bool isAlive;
    public bool isMoving=false;
    public bool isStop;
    public bool isTakeDamage;
    public bool isStepInLadder;
    public bool isJump=false;
    public int dir;
  
}
