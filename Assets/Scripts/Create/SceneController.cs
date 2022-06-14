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
    bool _StopTimer = false;
    GameObject _playerlife;
    // Start is called before the first frame update
    void Start()
    {
        _playerlife = GameObject.Find("hikousenn");
    }

    // Update is called once per frame
    void Update()
    {
        if(_StopTimer == false)
        {
            _timer += Time.deltaTime;
            float _count = 60 - _timer;
            _time.text = $"TIME:{_count.ToString("f2")}";
            if (_count <= 0.02)
            {
                _Clear1.gameObject.SetActive(true);
                _Clear2.gameObject.SetActive(true);
                _BackGround.gameObject.SetActive(true);
                _StopTimer = true;
            }
        }
    }
}
