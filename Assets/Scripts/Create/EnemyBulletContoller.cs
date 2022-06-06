using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBulletContoller : MonoBehaviour
{
    [SerializeField] float m_position = -5f;
    GameObject m_damage;
    //[SerializeField] GameObject m_damage;
    //Start is called before the first frame update
    void Start()
    {
        m_damage = GameObject.Find("LifeController");
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
        if(collision.gameObject.tag == "Player")
        {
            
            m_damage.GetComponent<LifeController>().Life();
        }
    }
}
