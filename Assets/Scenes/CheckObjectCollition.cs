using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObjectCollition : MonoBehaviour
{
     //Detect collisions between the GameObjects with Colliders attached
     float x;
     void OnTriggerEnter(Collider col)
    {
        x += 1;
        Debug.Log(col.name +" : "+x);
    }

    void OnTriggerStay(Collider col)
    {
        x += 1;
        Debug.Log(col.name +" : "+x);
    }

    void OnTriggerExit(Collider col)
    {
        x += 1;
        Debug.Log(col.name +" : "+x);
    }
}
