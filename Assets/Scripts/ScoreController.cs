using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text _scoretext;
    public static int m_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int score)
    {
        m_score += score;   // m_score = m_score + score の短縮形
        Debug.LogFormat("Score: {0}", m_score);

        // スコアを画面に表示する
        Text scoreText = _scoretext.GetComponent<Text>();
        scoreText.text = "SCORE: " + m_score.ToString();
    }
}
