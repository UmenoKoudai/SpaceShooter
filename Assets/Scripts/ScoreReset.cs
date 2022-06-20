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
        var SC = _sc.GetComponent<ScoreController>();
        SC._oscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
