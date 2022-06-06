using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hikoukibreak : MonoBehaviour
{
    AudioSource m_audio = default;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_audio = GetComponent<AudioSource>();
        m_audio.Play();
    }
}
