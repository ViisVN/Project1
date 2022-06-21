using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pictureconstantmove : MonoBehaviour
{
    private Vector3 posA;
    private Vector3 posB;

    private Vector3 nexpos;

    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform childtransform;

     [SerializeField]
    private Transform transformB;
    // Start is called before the first frame update
    void Start()
    {
        posA = childtransform.localPosition;
        posB = transformB.localPosition;
        nexpos = posB;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        childtransform.localPosition = Vector3.MoveTowards(childtransform.localPosition,nexpos,speed * Time.deltaTime);
        if(Vector3.Distance(childtransform.localPosition,nexpos)<=0.1)
        {
            Changedestination();
        }
    }
    private void Changedestination()
    {
        nexpos = nexpos != posA ? posA:posB;
    }
}
