using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMESTART : MonoBehaviour
{
    AudioSource _music;
    // Start is called before the first frame update
    void Start()
    {
        _music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("mouse0"))
        {
            SceneManager.LoadScene("Round1");
            _music.Play();
        }
    }
}
