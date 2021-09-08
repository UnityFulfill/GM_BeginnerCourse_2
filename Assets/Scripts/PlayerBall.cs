using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    bool isJump;
    AudioSource audio;
    Rigidbody rigid;

    void Awake() {
        jumpPower = 30;
        isJump = false;
        audio = GetComponent<AudioSource>();
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

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Floor") {
            isJump = false;
        }
    }

     void OnTriggerEnter(Collider collider) {
        if(collider.tag == "Item") {
            itemCount++;
            audio.Play();
            collider.gameObject.SetActive(false);
        }
    }
}
