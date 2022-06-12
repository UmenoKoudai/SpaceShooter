using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBulletContoller : MonoBehaviour
{
    [SerializeField] float m_position = -5f;
    [SerializeField] float m_initialSpeed = 3f;
    GameObject m_damage;
    //[SerializeField] GameObject m_damage;
    //Start is called before the first frame update
    void Start()
    {
        m_damage = GameObject.Find("LifeController");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = this.transform.up * m_initialSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= m_position)
        {
            Destroy(this.gameObject);
        }
    }
}
