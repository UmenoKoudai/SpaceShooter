using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectContoroller : MonoBehaviour
{
    [SerializeField] float m_intavar = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, m_intavar);
    }
}
