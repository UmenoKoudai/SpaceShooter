using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    //GameObject m_life = default;
    [SerializeField] Image m_life = default;
    // Start is called before the first frame update
    void Start()
    {
        //m_life = GameObject.Find("Life");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Life()
    {
        m_life.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
