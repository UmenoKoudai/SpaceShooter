using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossEnemyController : MonoBehaviour
{
	[Header("Object creation")]
	[SerializeField] GameObject _mainweapon1;
	[SerializeField] GameObject _mainweapon2;
	[SerializeField] GameObject _sabweapon1;
	[SerializeField] GameObject _sabweapon2;
	[Header("creation position")]
	[SerializeField] Transform _mainweapon1position;
	[SerializeField] Transform _mainweapon2position;
	[SerializeField] Transform _sabweapon1position;
	[SerializeField] Transform _sabweapon2position;
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
			Instantiate(_mainweapon1, _mainweapon1position.position, transform.rotation);
			Instantiate(_mainweapon2, _mainweapon2position.position, transform.rotation);
			Instantiate(_sabweapon1, _sabweapon1position.position, transform.rotation);
			Instantiate(_sabweapon2, _sabweapon2position.position, transform.rotation);
		}
		if (_EnemyHp == 0)
		{
			_timer += Time.deltaTime;
			ScoreController sc = _scorecontroller.GetComponent<ScoreController>();
			sc.AddScore(m_score);
			Instantiate(_Effect, this.transform.position, this.transform.rotation);
			Destroy(gameObject);
			float randomX = Random.Range(-boxCollider2D.size.x, boxCollider2D.size.x);
			float randomY = Random.Range(-boxCollider2D.size.y, boxCollider2D.size.y);

				// Generate the new object
			GameObject newObject = Instantiate<GameObject>(_Effect);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
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
}
