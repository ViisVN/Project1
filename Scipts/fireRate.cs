using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireRate : MonoBehaviour
{
    public float Bulletspeed = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Pickup(other);
        }
    }
    void Pickup(Collider2D bullet)
    {
        Shootbullet fr = bullet.GetComponent<Shootbullet>();
        fr.bulletVelocity += Bulletspeed;

        Destroy(gameObject);
    }
}
