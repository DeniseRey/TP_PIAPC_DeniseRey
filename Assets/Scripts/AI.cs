using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _target2;
    [SerializeField] private Transform _target3;
    [SerializeField] private GameObject _nextPointObject;
    public Light Luz1;
    public Light Luz2;
    public Light Luz3;
    
    private float time=0f;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
         Luz1.color = Color.white;
    }

    void Update()
    {
        if(Luz1.GetComponent<TargetBehaviour>().colision){
             gameObject.GetComponent<NavMeshAgent>().enabled=false;
            Destroy(gameObject.GetComponent<Rigidbody>());
           return;
        }
        time+=Time.deltaTime;
        if (time>1){
            if(Luz1.color == new Color(1f,0f,0.9f,1f)){
                Luz1.color = Color.white;
                Luz1.GetComponent<NavMeshObstacle>().enabled=true;
            }
            else{
                Luz1.color = new Color(1f,0f,0.9f,1f);
                Luz1.GetComponent<NavMeshObstacle>().enabled=false;
            }
            time = 0;
        }
       
        if(Luz2.color == Color.blue && Luz3.color==Color.green){
            _agent.SetDestination(_target.position);
        }
        else if(Luz3.color == Color.green){
             _agent.SetDestination(_target2.position);
        }
        else {
            _agent.SetDestination(_target3.position);
        }

        Instantiate(_nextPointObject, _agent.nextPosition, transform.rotation);

    }
}
