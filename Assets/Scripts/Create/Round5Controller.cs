using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Round5Controller : MonoBehaviour
{
    [SerializeField] GameObject _BossEnemy;
    [SerializeField] Image _warning;
    [SerializeField] AudioSource _BGM;
    [SerializeField] AudioSource _warningsound;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Boss", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Boss()
    {
        _warning.gameObject.SetActive(false);
        _BossEnemy.gameObject.SetActive(true);
        _warningsound.gameObject.SetActive(false);
        _BGM.gameObject.SetActive(true);
    }
}
