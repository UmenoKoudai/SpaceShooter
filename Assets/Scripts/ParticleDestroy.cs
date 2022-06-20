using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ObjectDestroy", 1.0f);
    }
    void ObjectDestroy()
    {
        Destroy(gameObject);
    }
}
