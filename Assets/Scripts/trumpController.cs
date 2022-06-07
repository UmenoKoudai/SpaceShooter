using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trumpController : MonoBehaviour
{
    [SerializeField] Image _Gauge1;
    [SerializeField] Image _Gauge2;
    [SerializeField] Image _Gauge3;
    [SerializeField] Image _Gauge4;
    [SerializeField] Image _Gauge5;
    [SerializeField] Image _Gauge6;
    [SerializeField] Image _Gauge7;
    [SerializeField] Image _Gauge8;
    [SerializeField] Image _Gauge9;
    [SerializeField] Image _GaugeFull;
    ParticleSystem _particle;
    int _count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            
            _count++;
            switch(_count)
            {
                case 1:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge2.gameObject.SetActive(true);
                    break;
                case 2:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge3.gameObject.SetActive(true);
                    break;
                case 3:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge4.gameObject.SetActive(true);
                    break;
                case 4:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge5.gameObject.SetActive(true);
                    break;
                case 5:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge6.gameObject.SetActive(true);
                    break;
                case 6:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge7.gameObject.SetActive(true);
                    break;
                case 7:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge8.gameObject.SetActive(true);
                    break;
                case 8:
                    _Gauge1.gameObject.SetActive(false);
                    _Gauge9.gameObject.SetActive(true);
                    break;
                default:
                    _Gauge1.gameObject.SetActive(false);
                    _GaugeFull.gameObject.SetActive(true);
                    if(Input.GetButtonDown("Enter"))
                    {
                        _particle.Play();
                        _count = 0;
                    }
                    break;
            }
        }
    }
}
