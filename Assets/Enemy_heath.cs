using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_heath : MonoBehaviour
{
    public float hp =10;
    public SpriteRenderer sprite;
    public GameObject corpse;
    //Change color
    public IEnumerator Flashred()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
    //Tru hp
    public void OnTriggerEnter2D(Collider2D other)
    {
           if(other.CompareTag("Bullet"))
        {
            hp-=2;
            StartCoroutine(Flashred());
        }

        if(hp<=0)
        {
            Destroy(gameObject);
            Instantiate(corpse,transform.position,transform.rotation);
        }
    }
}
