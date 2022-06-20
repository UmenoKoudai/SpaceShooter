using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossEnemyController : MonoBehaviour
{
	[Header("Object creation")]
	[SerializeField] GameObject _mainweapon1;
	[SerializeField] GameObject _mainweapon2;
	[Header("creation position")]
	[SerializeField] Transform _mainweapon1position;
	[SerializeField] Transform _mainweapon2position;
	[Header("Other options")]
	[SerializeField] float m_interval = 1;
	[SerializeField] Image _Life;
	float m_time;
	GameObject _scorecontroller;
	int m_score = 10000;
	[SerializeField] int _EnemyHp;
	[SerializeField] GameObject _Effect;
	[SerializeField] Transform _effectposition;
	private BoxCollider2D boxCollider2D;
	float _timer;
	void Start()
    {
		_scorecontroller = GameObject.Find("ScoreController");
		boxCollider2D = GetComponent<BoxCollider2D>();
	}

    // Update is called once per frame
    void Update()
    {
		m_time += Time.deltaTime;
		if (m_time > m_interval)
		{
			//Transform _rotation = transform rotation.z
			m_time = 0;
			Instantiate(_mainweapon1, _mainweapon1position.position, Quaternion.Euler(0, 0, 180));
			//go.transform.rotation = Quaternion.Euler(0, 0, 180);
			Instantiate(_mainweapon2, _mainweapon2position.position, Quaternion.Euler(0, 0, 180));
		}
		if (_EnemyHp <= 0)
		{
			_timer += Time.deltaTime;
			ScoreController sc = _scorecontroller.GetComponent<ScoreController>();
			sc.AddScore(m_score);
			Instantiate(_Effect, this.transform.position, this.transform.rotation);
			Destroy(gameObject);
			Invoke("LoadScene", 3f);
		}
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
		if(collision.gameObject.tag == "Bullet")
        {
			_Life.GetComponent<Image>().fillAmount -= 0.01f;
			_EnemyHp--;

		}
	}
	void LoadScene()
    {
		SceneManager.LoadScene("GAMECLEAR");
		Debug.Log("ìÆçÏÇµÇΩ");
	}
}