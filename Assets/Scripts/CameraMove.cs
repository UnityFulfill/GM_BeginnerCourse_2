using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTranform;
    Vector3 offset;

    void Awake()
    {
        playerTranform = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTranform.position;
    }

    void LateUpdate()
    {
        transform.position = playerTranform.position + offset;
    }
}
