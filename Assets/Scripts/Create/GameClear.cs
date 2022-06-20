using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    [SerializeField] GameObject _BossEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_BossEnemy == null)
        {
            Invoke("LoadScene", 5.0f);
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene("GAMECLEAR");
        Debug.Log("ìÆçÏÇµÇΩ");
    }
}
