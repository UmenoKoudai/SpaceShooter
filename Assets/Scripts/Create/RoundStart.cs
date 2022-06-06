using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundStart : MonoBehaviour
{
    [SerializeField] string _SceneName;
    float _timer = default;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        float _count = 5 - _timer;
        if (_count <= 0.01)
        {
            SceneManager.LoadScene(_SceneName);
        }
    }
}
