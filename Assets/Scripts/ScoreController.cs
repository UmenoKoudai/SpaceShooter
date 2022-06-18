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
        m_score += score;   // m_score = m_score + score �̒Z�k�`
        Debug.LogFormat("Score: {0}", m_score);

        // �X�R�A����ʂɕ\������
        Text scoreText = _scoretext.GetComponent<Text>();
        scoreText.text = "SCORE: " + m_score.ToString();
    }
}
