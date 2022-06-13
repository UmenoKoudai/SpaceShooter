using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipContolloer : MonoBehaviour
{
    [SerializeField] float m_position = -5f;
    [SerializeField] float m_intavar = 0.3f;
    [SerializeField] GameObject _Particle;
    ParticleSystem _effect;
    GameObject _player;
    GameObject _scorecontroller;
    int m_score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        _effect = GetComponent<ParticleSystem>();
        _player = GameObject.Find("hikousenn");
        _scorecontroller = GameObject.Find("ScoreController");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= m_position)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            ScoreController sc = _scorecontroller.GetComponent<ScoreController>();
            sc.AddScore(m_score);
            Destroy(gameObject, m_intavar);
            Instantiate(_Particle, transform.position, transform.rotation);
        }
    }
}
