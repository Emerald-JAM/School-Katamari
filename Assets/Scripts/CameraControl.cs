using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float turnSpeed = 5.0f;
    public GameObject player;
    private Transform playerTransform;
    private Vector3 offset;
    private float yOffset = 10.0f;
    private float zOffset = 10.0f;
    public bool userRotation;

    void Start()
    {
        playerTransform = player.transform;
        offset = new Vector3(playerTransform.position.x, playerTransform.position.y + yOffset, playerTransform.position.z + zOffset);
        transform.position = playerTransform.position + offset;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //input.GetMouseButtonDown
        //  --To Do-- Make camera actively follow player ALWAYS (copy from other camera script)
        if (Input.GetMouseButton(0))
        {
            userRotation = true;
        }
        else
        {
            userRotation = false;
        }
        if (userRotation == true)
        {
            //Debug.Log("Camera Working");
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
            transform.position = playerTransform.position + offset;
            
            if (this.transform.localEulerAngles.x > 9 && this.transform.localEulerAngles.x < 55)
            {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offset;
                transform.position = playerTransform.position + offset;
                transform.LookAt(playerTransform.position);
            }

        }
        if (this.transform.localEulerAngles.x <= 9)
        {
            //userRotation = false;
            transform.localEulerAngles = new Vector3(10, transform.localEulerAngles.y, transform.localEulerAngles.z);
            Debug.Log(transform.localEulerAngles.x);
        }
        else if (transform.localEulerAngles.x >= 55)
        {
            //userRotation = false;
            this.transform.localEulerAngles = new Vector3(54, transform.localEulerAngles.y, transform.localEulerAngles.z);
            Debug.Log(transform.localEulerAngles.x);
        }
    }
}       