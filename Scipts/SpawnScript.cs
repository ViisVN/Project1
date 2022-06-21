using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public int NumberOfEnemies;
    public List<GameObject> SpawnObject;
    public GameObject Quad;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        //Instantiate(SpawnObject[Random.Range(0, SpawnObject.Length)], SpawnLocations[Random.Range(0, SpawnLocations.Length)]);
    }
    public void Spawn()
    {
        int randomitem = 0;
        GameObject toSpawn;
        MeshCollider c = Quad.GetComponent<MeshCollider>();
        float screenX, screenY;
        Vector2 screenPosition;
        for (int i = 0; i < NumberOfEnemies; i++)
        {
            randomitem = Random.Range(0, SpawnObject.Count);
            toSpawn = SpawnObject[randomitem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            screenPosition = new Vector2(screenX, screenY);
            Instantiate(toSpawn, screenPosition, toSpawn.transform.rotation);
        }
    }
}

