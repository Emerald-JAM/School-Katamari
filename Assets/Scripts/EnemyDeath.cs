﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= -10)
        {
            gameObject.SetActive(false);
        }
    }
     void OnParticleCollision(GameObject other)
    {
        gameObject.SetActive(false);
    }
}
