using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	//Comment by Thien

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("q"))
        {
            foreach (Transform child in transform)
            {
                child.gameObject.GetComponent<Collider>().enabled = true;
                child.transform.parent = null;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("item") && Input.GetKey("e"))
        {
            collision.transform.parent = transform;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
