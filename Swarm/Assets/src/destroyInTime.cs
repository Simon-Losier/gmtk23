using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float time = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, time);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("grimace") || other.gameObject.CompareTag("human"))
        {
            Debug.Log("Destroying grimace");
            Destroy(gameObject);
        }
    }
}
