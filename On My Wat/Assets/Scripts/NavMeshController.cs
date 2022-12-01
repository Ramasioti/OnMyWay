using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{

    public Transform[] objetive;

    public float brumbrum;

    private NavMeshAgent agente;


    void Start()
    {
        Destination();
    }

    
    void Update()
    {
        
    }

    void Destination()
    {
        agente = GetComponent<NavMeshAgent>();

        agente.destination = objetive[0].position;

        agente.speed = brumbrum;

       
 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PuntoControl"))
        {
            agente.destination = objetive[1].position;
            
        }

        if(other.gameObject.CompareTag("Destroy"))
        {
            

        }

    }
}
