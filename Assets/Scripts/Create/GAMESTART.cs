using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMESTART : MonoBehaviour
{
    [SerializeField] string _roundname;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("mouse0"))
        {
            Debug.Log("‰Ÿ‚µ‚½");
            SceneManager.LoadScene("_roundname");
        }
    }
}
