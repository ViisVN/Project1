using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 60f;
    public float maxHealth = 100f;
    public float speed = 7f;
    public float damage = 1f;

    //Change color

    private void Update()
    {
        takeDamage();
    }
    void takeDamage()
    {
        if (health < 1f)
        {
            Destroy(gameObject);
        }
    }
}
