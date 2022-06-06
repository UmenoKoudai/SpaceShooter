using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDroop : MonoBehaviour
{
    [SerializeField] GameObject m_itemPrefab = default;
    [SerializeField] Transform m_Muzzle = default;

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            // �G�t�F�N�g�ƂȂ�v���n�u���ݒ肳��Ă�����A����𐶐�����
            if (m_itemPrefab)
            {
                Instantiate(m_itemPrefab, m_Muzzle.position, this.transform.rotation);
            }
        }
    }*/
    private void OnDestroy()
    {
        if (m_itemPrefab)
        {
            Instantiate(m_itemPrefab, m_Muzzle.position, this.transform.rotation);
        }
    }
}
