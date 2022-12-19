using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{

    public Transform[] objetive;

    public float brumbrum;

    private NavMeshAgent agente;

    private int i = 0;

    public int numero;


    void Start()
    {
        Destination();
        brumbrum = PlayerPrefs.GetFloat("save" + numero, brumbrum);

        
        Debug.Log(brumbrum);
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

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PuntoControl"))
        {
            i++;
            agente.destination = objetive[i].position;
            agente.speed = brumbrum;
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }

    }




    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    agente.isStopped = true;
        //}


        if (collision.gameObject.CompareTag("Semaforo"))
        {
            agente.isStopped = true;

        }


    }

    private void OnCollisionStay(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    agente.isStopped = true;
            
            
        //}


        //if (collision.gameObject.CompareTag("Semaforo"))
        //{
        //    agente.isStopped = true;
            

        //}

    }

    private void OnCollisionExit(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{

        //    agente.isStopped = false;

        //}

        if (collision.gameObject.CompareTag("Semaforo"))
        {

            agente.isStopped = false;


        }
    }



}
