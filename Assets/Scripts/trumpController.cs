using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trumpController : MonoBehaviour
{
    [SerializeField] Image _Gauge;
    GameObject _Player;
    public int _count;
    // Start is called before the first frame update
    void Start()
    {
        _Player = GameObject.Find("hikousenn");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Charg()
    {
        _Gauge.GetComponent<Image>().fillAmount += 0.1f;
        ParticleSystem _player = _Player.GetComponent<ParticleSystem>();
        _count++;
        if(_count >= 10 && Input.GetButtonDown("Fire3"))
        {
            Debug.Log("ƒgƒ‰ƒ“ƒUƒ€");
            _Gauge.GetComponent<Image>().fillAmount -= 1f;
            _player.Play();
            _count = 0;
        }
    }
}
