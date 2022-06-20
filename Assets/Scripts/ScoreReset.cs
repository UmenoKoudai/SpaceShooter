using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{
    GameObject _sc;
    // Start is called before the first frame update
    void Start()
    {
        _sc = GameObject.Find("ScoreController");
    }

    // Update is called once per frame
    void Update()
    {
        var SC = _sc.GetComponent<ScoreController>();
        SC._score = 0; 
    }
}
