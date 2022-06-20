using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text _scoretext;
    GameObject _ec;
    public static int m_score;
    public int _oscore;
    // Start is called before the first frame update
    void Start()
    {
        _ec = GameObject.Find("EndScore");
        
    }

    // Update is called once per frame
    void Update()
    {
        _oscore = m_score;
        var EC = _ec.GetComponent<EndScore>();
        EC.m_score = _oscore;
    }
    public void AddScore(int score)
    {
        m_score += score;   // m_score = m_score + score の短縮形
        Debug.LogFormat("Score: {0}", _oscore);
        // スコアを画面に表示する
        Text scoreText = _scoretext.GetComponent<Text>();
        scoreText.text = "Score: " + _oscore.ToString("000000");
    }
}
