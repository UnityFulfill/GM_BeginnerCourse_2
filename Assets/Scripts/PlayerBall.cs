using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower = 30;
    bool isJump;
    Rigidbody rigid;

    void Awake() {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
    }

    void Update() {
        if(!isJump && Input.GetButtonDown("Jump")) {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
    
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision Collision) {
        if(Collision.gameObject.name == "Floor") {
            isJump = false;
        }
    }
}