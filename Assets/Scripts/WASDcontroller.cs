using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDcontroller : MonoBehaviour
{
    public float thrust = 0.2f;
    public float x;
    public float y;
    public float z;
    public Rigidbody rb;
    public SceneManagement yes;
    public Camera cameraObj;
    private Vector3 movementForce;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        yes = GameObject.Find("goal").GetComponent<SceneManagement>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        x = 0;
        //y = 0;
        z = 0;
        if (Input.GetKey("w"))
        {
            //rb.AddForce(0, 0, thrust, ForceMode.Impulse);
            z = thrust;
        }
        if (Input.GetKey("s"))
        {
            //rb.AddForce(0, 0, -thrust, ForceMode.Impulse);
            z = -thrust;
        }
        if (Input.GetKey("a"))
        {
            //rb.AddForce(-thrust, 0, 0, ForceMode.Impulse);
            x = -thrust;
        }
        if (Input.GetKey("d"))
        {
            //rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
            x = thrust;
        }
        if (Input.GetKey("space"))
        {
            GameObject system = GameObject.Find("Attack Particles");
            system.GetComponent<ParticleSystem>().Play(true);
        }
        if (Input.GetKey("p"))
        {
            yes.nextLevel();
        }
        /*if (Input.GetKeyDown("right shift") || Input.GetKeyDown("left shift"))
        {
            thrust += 0.2f;
        }*/



        movementForce = new Vector3(x, y, z);
        movementForce = cameraObj.transform.TransformDirection(movementForce);
        rb.AddForce(movementForce, ForceMode.Impulse);
        //rb.MovePosition(rb.position + movementForce);
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("floor") || collision.gameObject.name.Contains("wall") || collision.gameObject.name.Contains("item"))
        {
            if (Input.GetKey("space"))
            {
                y = thrust;
            }
        }
    }*/
}
