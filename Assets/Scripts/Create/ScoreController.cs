using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text _scoretext;
    GameObject _ec;
    public static int m_score;
    public int _score;
    // Start is called before the first frame update
    void Start()
    {
        _ec = GameObject.Find("EndScore");
        SP();
    }

    // Update is called once per frame
    void Update()
    {
        var EC = _ec.GetComponent<EndScore>();
        EC.m_score = _score;
    }
    public void AddScore(int score)
    {
        m_score += score;   // m_score = m_score + score �̒Z�k�`
        Debug.LogFormat("Score: {0}", m_score);

        _score = m_score;
        // �X�R�A����ʂɕ\������
        Text scoreText = _scoretext.GetComponent<Text>();
        scoreText.text = "SCORE: " + _score.ToString();
    }
    void SP()
    {
        _score += 0;
    }
}
