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
        Animator An = _player.GetComponent<Animator>();
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("������");
            An.SetBool("BD", true);
            Invoke("LoadScene", 2f);
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(_roundname);
    }
}
