using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed;
    private Vector3 delta;

    // Start is called before the first frame update
    void Start()
    {
        delta = Camera.main.transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, target.position + delta, lerpSpeed * Time.deltaTime);
    }
}
