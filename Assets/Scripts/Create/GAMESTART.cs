using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMESTART : MonoBehaviour
{
    [SerializeField] string _roundname;
    GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Animation An = _player.GetComponent<Animation>();
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("‰Ÿ‚µ‚½");
            An.Play();
            Invoke("LoadScene", 5f);
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(_roundname);
    }
}
