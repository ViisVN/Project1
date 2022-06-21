using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdisapper : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update


    // Update is called once per frame
   /* void Update()
    {
        /*timer += 1.0f * Time.deltaTime;
        if(timer>=2)
        {
            GameObject.Destroy(gameObject);
        }
      
    }*/
     void OnTriggerEnter2D(Collider2D other)   
    {
         if (other.CompareTag("Enemy"))
        {
            Pickup(other);
        }
    }
    void Pickup(Collider2D enemy)
    {        
        Destroy(gameObject);
    
     }
}
       
