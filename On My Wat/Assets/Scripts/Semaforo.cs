using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
{
   private Collider paredon;

   private bool V = true;
    

   public float tiempoPrende;
   public float tiempoApaga;

    public int numero;


    void Start()
    {
        paredon = GetComponent<Collider>();

        int n = (numero - 1) * 2; 
        tiempoPrende = PlayerPrefs.GetFloat("save" + (n + 1), tiempoPrende);
        tiempoApaga = PlayerPrefs.GetFloat("save" + (n + 2), tiempoApaga);

        //Debug.Log(n);
        //Debug.Log(tiempoPrende);
        //Debug.Log(tiempoApaga);
        //Debug.Log("save" + n + 1);


        Invoke("Verde", tiempoPrende);

    }

    
    void Update()
    {
        if (V)
        {
            Invoke("Rojo", tiempoApaga);
            
        }
        
        if (V == false)
        {
            Invoke("Verde", tiempoPrende);
        }

       
    }

    

    void Verde()
    {
        paredon.isTrigger = V = true;
        Debug.Log("Verde");
        CancelInvoke();
        
        
    }

    void Rojo()
    {
        paredon.isTrigger = V = false;
        Debug.Log("Rojo");
        CancelInvoke();
    }

   
}
