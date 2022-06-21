using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_heath : MonoBehaviour
{
    // Start is called before the first frame update
    public float hp =10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
             if(other.CompareTag("Bullet"))
        {
            hp-=2;
        }

        if(hp<=0)
        {
            Destroy(gameObject);
        }
    }
}
