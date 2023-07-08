using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 5;

    public GameObject Cannonball;
    public Transform ShotPoint;

    //public GameObject Explosion;
    public void Throw()
    {
        float HorizontalRotation = Input.GetAxis("Horizontal");
        float VericalRotation = Input.GetAxis("Vertical");

        GameObject CreatedCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
        CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.forward * BlastPower;
        
        // Added explosion for added effect
        //Destroy(Instantiate(Explosion, ShotPoint.position, ShotPoint.rotation), 2);
        
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Throw();
        }
    }
}
