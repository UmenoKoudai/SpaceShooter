using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trumpController : MonoBehaviour
{
    [SerializeField] Image _Gauge1 = default;
    [SerializeField] Image _Gauge2 = default;
    [SerializeField] Image _Gauge3 = default;
    [SerializeField] Image _Gauge4 = default;
    [SerializeField] Image _Gauge5 = default;
    [SerializeField] Image _Gauge6 = default;
    [SerializeField] Image _Gauge7 = default;
    [SerializeField] Image _Gauge8 = default;
    [SerializeField] Image _Gauge9 = default;
    [SerializeField] Image _GaugeFull = default;
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

    void Charge(int _count)
    {
        switch (_count)
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
                if (Input.GetButtonDown("Enter"))
                {
                    _particle.Play();
                    _count = 0;
                }
                break;
        }
    }
}
