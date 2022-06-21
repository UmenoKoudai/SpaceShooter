using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBack : MonoBehaviour
{
    public int m_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadTitle(string SN)
    {
        SceneManager.LoadScene(SN);
    }

    public void ResetScore()
    {
        m_score -= m_score;
    }
}
