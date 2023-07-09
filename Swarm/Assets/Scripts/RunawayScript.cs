using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class RunawayScript : MonoBehaviour
{

    [SerializeField] private NavMeshAgent agent = null;
    [SerializeField] private Transform chaser = null;
    [SerializeField] private float displacementDistance = 5f;
    
    [SerializeField] private float currDeltaDistance = 15f;

    [SerializeField] private Material human;
    [SerializeField] private Material zombie;

    [SerializeField] private GameObject characterModel;
    // Possible states: human, zombie
    public string state = "human";

    private RunAnimation animator;

    
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("grimace") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("grimaceBall")) && state.Equals("human"))
        {
            Grimace();
        }
    }

    /**
     * Turns the human into grimace
     */
    private void Grimace()
    {
        state = "zombie";
        tag = "grimace";
        
        // Get renderer
        UnityEngine.Renderer myRenderer = GetComponent<UnityEngine.Renderer>();
        
        // Chaning color
        Color newColor = new Color(1,0,1);
        myRenderer.material.color = newColor;
        
        // Change the Matereal of the human
        myRenderer = characterModel.GetComponent<UnityEngine.Renderer>();
        myRenderer.material = zombie;
        
        //add a point to the player
        Points.AddPoints(1);
        
        //change the speed of the zombie
        agent.speed = 30;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (agent == null)
        {
            if (!TryGetComponent(out agent))
            {
                Debug.LogWarning(name + " needs a navmesh agent");

            }
        }

        characterModel = GetComponentInChildren<Renderer>().gameObject;
        animator = GetComponent<RunAnimation>();
    }
    
    private void MoveToPos(Vector3 pos)
    {
        agent.SetDestination(pos);
        agent.isStopped = false;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (chaser == null)
        {
            return;
        }

        if (state.Equals("human"))
        {
            float deltaDistance = Vector3.Distance(chaser.position, transform.position);
            Vector3 normalizedDirection = (chaser.position - transform.position).normalized;


            if (currDeltaDistance > deltaDistance)
            {
                MoveToPos(transform.position - (normalizedDirection * displacementDistance));
            }
        }
        else if (state.Equals("zombie"))
        {
            //Vector3 normalizedDirection = (chaser.position - transform.position).normalized;

            MoveToPos(chaser.position);
            
        }
        Debug.Log(agent.velocity);
        if (agent.velocity.magnitude > 0) {
            Debug.Log("citizen running");
            animator.Run();
        }
        else {
            Debug.Log("citizen idling");
            animator.Idle();
        }
    }
}
