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

    // Possible states: human, zombie
    public string state = "human";

    
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("grimace") || collision.gameObject.CompareTag("Player")) && state.Equals("human"))
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
        UnityEngine.Renderer myRenderer = GetComponent<UnityEngine.Renderer>();
        Color newColor = new Color(1,0,1);
        myRenderer.material.color = newColor;
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

        float deltaDistance = Vector3.Distance(chaser.position, transform.position);
        Vector3 normalizedDirection = (chaser.position - transform.position).normalized;


        if (currDeltaDistance > deltaDistance)
        {
            MoveToPos(transform.position - (normalizedDirection * displacementDistance));
        }
    }
}
