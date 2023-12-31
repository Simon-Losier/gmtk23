using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {
    [SerializeField] public Transform swarmLead;
    [SerializeField] public float speed;
    [SerializeField] public float maxSpeed;
    [SerializeField] public float stoppingDistance;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update() {
        
        transform.LookAt(new Vector3(swarmLead.position.x, transform.position.y, swarmLead.position.z));
        if (Vector3.Distance(transform.position, new Vector3(swarmLead.position.x, transform.position.y, swarmLead.position.z)) > stoppingDistance) {
            if (rb.velocity.magnitude < maxSpeed) {
                rb.AddForce(transform.forward * speed, ForceMode.Force);
            }
        }
        else {
            rb.velocity = Vector3.zero;
        }
    }
}