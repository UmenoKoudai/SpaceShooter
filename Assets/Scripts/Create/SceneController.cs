using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] Image _Clear1;
    [SerializeField] Image _Clear2;
    [SerializeField] Image _BackGround;
    [SerializeField] Text _time;
    float _timer = default;
    [SerializeField] bool _StopTimer = false;
    public int _hp;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if(_StopTimer == false)
        {
            _timer += Time.deltaTime;
            float _count = 60 - _timer;
            _time.text = $"TIME:{_count.ToString("f2")}";
            if (_count <= 0.01f)
            {
                Debug.Log("ƒJƒEƒ“ƒg0");
                _Clear1.gameObject.SetActive(true);
                _Clear2.gameObject.SetActive(true);
                _BackGround.gameObject.SetActive(true);
                _StopTimer = true;
            }
        }
        if(_hp <= 0)
        {
            _StopTimer = true;
        }
    }
}
