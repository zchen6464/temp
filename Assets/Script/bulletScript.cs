﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public float speed;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.up * speed;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
    
    // Update is called once per frame
    void Update()
    {
    }
}
