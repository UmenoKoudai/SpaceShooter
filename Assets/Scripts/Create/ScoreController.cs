using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text _scoretext;
    GameObject _ec;
    public static int m_score;
    
    void Start()
    {
        _ec = GameObject.Find("EndScore");
    }

    void Update()
    {
        if (_ec)
        {
            var endScore = _ec.GetComponent<EndScore>();

            if (endScore)
            {
                endScore.m_score = m_score;
            }
        }
    }

    public void AddScore(int score)
    {
        m_score += score;   // m_score = m_score + score �̒Z�k�`
        Debug.LogFormat("Score: {0}", m_score);
        // �X�R�A����ʂɕ\������
        Text scoreText = _scoretext.GetComponent<Text>();
        scoreText.text = "Score: " + m_score.ToString("000000");
    }
    public void Reset()
    {
        m_score = 0;
    }

    public void Continue()
    {
        m_score -= 10000;
    }
}
