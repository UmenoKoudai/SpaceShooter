using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip2Contolloer : MonoBehaviour
{
    [SerializeField] float m_position = -5f;
    [SerializeField] GameObject m_effectPrefab = default;
    [SerializeField] float m_intavar = 0.3f;
    // Start is called before the first frame update
    void Start()
    {

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
        if (collision.gameObject.tag == "Bullet")
        {
            // エフェクトとなるプレハブが設定されていたら、それを生成する
            if (m_effectPrefab)
            {
                Instantiate(m_effectPrefab, this.transform.position, this.transform.rotation);
            }
            Destroy(gameObject, m_intavar);
        }
    }
}
