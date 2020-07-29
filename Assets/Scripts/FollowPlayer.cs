using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed;
    private Transform target;
    public GameObject targetObject;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //target = player.GetComponent<Transform>();
        targetObject = GameObject.Find("player");
        target = targetObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject == null)
        {
            targetObject = GameObject.Find("player");
            target = targetObject.GetComponent<Transform>();
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
