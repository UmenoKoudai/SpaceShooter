using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController : MonoBehaviour
{
    [SerializeField] float m_initialSpeed = 3f;
    [SerializeField] float m_position = -15f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * m_initialSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= m_position)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Baria")
        {
            Destroy(gameObject);
        }
    }
}
