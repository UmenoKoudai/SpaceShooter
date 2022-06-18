using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    [SerializeField] Text Score;
    [SerializeField] Text BestScore;
    public static int m_score;
    int m_bestscore;
    float _time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        float t = 0.1f-_time;
        if(t <= 0)
        {
            Score.text = $"Score:{m_score}";
            if (m_bestscore >= m_score)
            {
                m_bestscore = m_score;
                BestScore.text = $"BestScore:{m_bestscore}";
            }
        }
    }
}
