using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    //public float speed = 5;
    private NavMeshAgent navMeshAgent;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //float mx = Input.GetAxis("Horizontal");
        //float my = Input.GetAxis("Vertical");

        //if (mx != 0 || my != 0)
        //{
        //    Vector3 pos = transform.position;
        //    Vector3 movement = new Vector3(mx, 0, my);
        //    pos += movement * speed * Time.deltaTime;
        //}

        if (target != null)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }
}
