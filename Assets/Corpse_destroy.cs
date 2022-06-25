using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corpse_destroy : MonoBehaviour
{
    float time = 120.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      time--;
      if(time==0)
      {
        Destroy(gameObject);
      }
    }   
}
