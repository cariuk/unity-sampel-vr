using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObjectCollition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
         Debug.Log("Hello: " + other.name);
    }
}
