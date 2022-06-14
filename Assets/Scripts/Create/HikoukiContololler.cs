using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HikoukiContololler : MonoBehaviour
{
    [SerializeField] float m_speed;
	[SerializeField] Transform m_muzzle = default; //弾Prefab出現場所設定
	[SerializeField] int _HP;
	[SerializeField] GameObject m_SoundPrefab;
	[SerializeField] Image _BackGround;
	[SerializeField] Image _GameOver;
	Rigidbody2D m_rd = default;
	[Header("Object creation")]
	AudioSource m_audio = default;
	public GameObject prefabToSpawn; //発射する弾のPrefabを登録
	public KeyCode keyToPress = KeyCode.Space; //弾を発生させるキーになるボタン
	[Header("Other options")]
	public float creationRate;
	public float shootSpeed;
	public Vector2 shootDirection = new Vector2(1f, 1f);
	public bool relativeToRotation = true;
	private float timeOfLastSpawn;
	private int playerNumber;
	float Powercount = 0;
	GameObject _LifeController;
	[SerializeField] Image _Gauge;
	//GameObject _Player;
	public int _count;
	float _timer;
	float _timers;
	public  bool _invincible;
	void Start()
    {
		timeOfLastSpawn = -creationRate;
		playerNumber = (gameObject.CompareTag("Player")) ? 0 : 1;
		_LifeController = GameObject.Find("LifeController");

	}

	void Update()
	{
		
		if (Input.GetKey(keyToPress)
		   && Time.time >= timeOfLastSpawn + creationRate)
		{
			Vector2 actualBulletDirection = (relativeToRotation) ? (Vector2)(Quaternion.Euler(0, 0, transform.eulerAngles.z) * shootDirection) : shootDirection;

			GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
			newObject.transform.position = m_muzzle.position;
			newObject.transform.eulerAngles = new Vector3(0f, 0f, Utils.Angle(actualBulletDirection));
			newObject.tag = "Bullet";

			Rigidbody2D rigidbody2D = newObject.GetComponent<Rigidbody2D>();
			if (rigidbody2D != null)
			{
				rigidbody2D.AddForce(actualBulletDirection * shootSpeed, ForceMode2D.Impulse);
			}

			BulletAttribute b = newObject.GetComponent<BulletAttribute>();
			if (b == null)
			{
				b = newObject.AddComponent<BulletAttribute>();
			}
			b.playerId = playerNumber;


			timeOfLastSpawn = Time.time;
		}
		ParticleSystem _player = GetComponent<ParticleSystem>();
		SpriteRenderer coler = GetComponent<SpriteRenderer>();
		_timers += Time.deltaTime;
		if (_count >= 10 && Input.GetButtonDown("Fire3"))
		{
			coler.color = Color.red;
			_timer += Time.deltaTime;
			Debug.Log("トランザム");
			_Gauge.GetComponent<Image>().fillAmount -= 1f;
			_player.Play();
			_count = 0;
			_invincible = true;
			creationRate = .01f;
			shootSpeed = 50f;
			m_speed = 400;
			_timers = 0;
		}
		else if(_timers >= 5)
        {
			coler.color = Color.white;
		}
		//変数Powercount内の数字により弾の速度変化
		if (Powercount == 0 && _timers >= 5)
		{
			creationRate = .5f;
			shootSpeed = 5f;
		}
		else if (Powercount == 1 && _timers >= 5)
		{
			creationRate = .3f;
			shootSpeed = 30f;
		}
		else if (Powercount >= 2 && _timers >= 5)
		{
			creationRate = .1f;
			shootSpeed = 50f;
		}
		if (_HP <= 0)
		{
			Instantiate(m_SoundPrefab, transform.position, transform.rotation);
			_BackGround.gameObject.SetActive(true);
			_GameOver.gameObject.SetActive(true);
			Destroy(gameObject);
		}
	}

	void OnDrawGizmosSelected()
	{
		if (this.enabled)
		{
			float extraAngle = (relativeToRotation) ? transform.rotation.eulerAngles.z : 0f;
			Utils.DrawShootArrowGizmo(transform.position, shootDirection, extraAngle, 1f);
		}
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
		//Power tagアイテムを取るごとに変数Powercountをインクリメント
		if (collision.gameObject.tag == "Power")
		{
			Powercount++;
		}
		if(collision.gameObject.tag == "Bullet2")
        {
			_HP -= 1;
			_LifeController.GetComponent<LifeController>().Life(0.1f);

		}
		if (collision.gameObject.tag == "BossEnemyBullet")
		{
			_HP -= 2;
			_LifeController.GetComponent<LifeController>().Life(0.2f);
		}
	}
	public void Charg()
	{
		_Gauge.GetComponent<Image>().fillAmount += 0.1f;
		_count++;
	}	
}
