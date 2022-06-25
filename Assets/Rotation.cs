using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
        void Update()
        {
           if(!Pausemenu.Gameispaused)
            {

            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);

            //Angle between mouse and this object
            float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);

            //Ta daa
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
           }
           else
          {

           }
        }

        float AngleBetweenPoints(Vector2 a, Vector2 b)
        {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }

    }

