using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
	private GameObject last_collided_item;
	
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
            /*foreach (Transform child in transform)
            {
                child.gameObject.GetComponent<Collider>().enabled = true;
                child.transform.parent = null;
            }*/

            var TempVar = FindObjectsOfType<GameObject>();
            for (int i = 0; i < TempVar.Length; i++)
            {
                if (TempVar[i].name.Contains("item"))
                {
                    TempVar[i].gameObject.GetComponent<Collider>().enabled = true;
                    TempVar[i].transform.parent = null;
                }
            }
        } else if(Input.GetKey("e")){
			if (last_collided_item.name.Contains("item"))
			{
				last_collided_item.transform.parent = this.transform;
				last_collided_item.GetComponent<Rigidbody>().isKinematic = true;
				last_collided_item.GetComponent<Collider>().enabled = false;
			}
		}
    }

    void OnCollisionEnter(Collision collision)
    {
		last_collided_item = collision.gameObject;
    }
}
