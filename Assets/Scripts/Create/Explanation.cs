using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explanation : MonoBehaviour
{
    [SerializeField] GameObject _1;
    [SerializeField] GameObject _2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _1.gameObject.SetActive(false);
            _2.gameObject.SetActive(true);
        }
    }
}
