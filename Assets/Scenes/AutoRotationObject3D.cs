using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotationObject3D : MonoBehaviour
{
    // Start is called before the first frame update
    float x;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * 20 ;
        transform.rotation = Quaternion.Euler(0,x,0);
    }
}
