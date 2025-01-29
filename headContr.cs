using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class headContr : MonoBehaviour
{
    public Transform playerBody;
    public CharacterController contr;
    public float speed = 12f;
    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * 2f;
        float mouseY = Input.GetAxis("Mouse Y");

        playerBody.Rotate(0, mouseX, 0);
        xRotation = xRotation - mouseY;

        xRotation = Math.Clamp(xRotation, -90f,90f);
        transform.localRotation = Quaternion.Euler(xRotation,0,0);

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        contr.Move(playerBody.forward * vertical * speed * Time.deltaTime);
        contr.Move(playerBody.right * speed * horizontal * Time.deltaTime);
    }

}
