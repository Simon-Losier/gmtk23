using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Infect : MonoBehaviour {
    void InfectCitizen() {
        Debug.Log("infecting citizen");
        Destroy(GetComponent<NavigationScript>());
        Destroy(GetComponent<RunawayScript>());
        Destroy(GetComponent<NavMeshAgent>());
        gameObject.AddComponent<Zombie>();
        GetComponent<Zombie>().swarmLead = GameObject.FindWithTag("Lead").transform;
        GetComponent<Zombie>().maxSpeed = 10;
        GetComponent<Zombie>().speed = 10;
        GetComponent<Zombie>().stoppingDistance = 2;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.CompareTag("grimace") || collision.transform.CompareTag("grimaceBall") || collision.transform.CompareTag("Player")) {
            InfectCitizen();
        }
    }
}
