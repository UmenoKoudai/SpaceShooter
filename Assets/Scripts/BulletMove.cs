using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] int _BulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(Vector2.down * _BulletSpeed, ForceMode2D.Force);
    }
}
