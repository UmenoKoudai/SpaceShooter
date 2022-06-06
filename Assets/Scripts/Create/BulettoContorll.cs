using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulettoContorll : MonoBehaviour
{
    [SerializeField] float m_position = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > m_position)
        {
            Destroy(gameObject);
        }
    }
}
