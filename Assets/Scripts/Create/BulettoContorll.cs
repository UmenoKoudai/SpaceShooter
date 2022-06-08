using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulettoContorll : MonoBehaviour
{
    [SerializeField] float m_position = 8.0f;
    [SerializeField] trumpController _charge;
    int _count;
    // Start is called before the first frame update
    void Start()
    {
        trumpController _charge = GetComponent<trumpController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > m_position)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            _count++;
            _charge._count = _count;
        }
    }
}
