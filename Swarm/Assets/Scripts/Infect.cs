using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Infect : MonoBehaviour {
    void InfectCitizen() {
        Debug.Log("infecting citizen");
        if (transform.GetComponent<RunawayScript>() != null &&
            transform.GetComponent<NavMeshAgent>() != null) {
            Destroy(transform.GetComponent<RunawayScript>());
            Destroy(transform.GetComponent<NavMeshAgent>());
        }
        if (transform.GetComponent<Zombie>() == null) {
            gameObject.AddComponent<Rigidbody>();    
            gameObject.AddComponent<Zombie>();
            transform.GetComponent<Zombie>().swarmLead = GameObject.FindWithTag("Player").transform;
            transform.GetComponent<Zombie>().maxSpeed = 30;
            transform.GetComponent<Zombie>().speed = 10;
            transform.GetComponent<Zombie>().stoppingDistance = .5f;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.CompareTag("grimace") || collision.transform.CompareTag("grimaceBall") || collision.transform.CompareTag("Player")) {
            InfectCitizen();
        }
    }
}
