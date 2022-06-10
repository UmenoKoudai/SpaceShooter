using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyController : MonoBehaviour
{
	[Header("Object creation")]
	[SerializeField] GameObject _mainweapon1;
	[SerializeField] GameObject _mainweapon2;
	[SerializeField] GameObject _sabweapon1;
	[SerializeField] GameObject _sabweapon2;
	public KeyCode keyToPress = KeyCode.Space;
	[Header("Other options")]
	public float creationRate = .5f;
	public float shootSpeed = 5f;
	public Vector2 shootDirection = new Vector2(1f, 1f);
	public bool relativeToRotation = true;
	private float timeOfLastSpawn;
	private int playerNumber;
	float m_time;
	[SerializeField] float m_interval = 1;
	[SerializeField] Transform _mainweapon1position;
	[SerializeField] Transform _mainweapon2position;
	[SerializeField] Transform _sabweapon1position;
	[SerializeField] Transform _sabweapon2position;
	Transform _rotation;
	void Start()
    {
		_rotation = GetComponent<Transform>();

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
		/*m_time += Time.deltaTime;
		if (m_time <= 0)*/
		/*m_time += Time.deltaTime;
		if (m_time > m_interval && Time.time >= timeOfLastSpawn + creationRate)
		{
			m_time = 0;
			Vector2 actualBulletDirection = (relativeToRotation) ? (Vector2)(Quaternion.Euler(0, 0, transform.eulerAngles.z) * shootDirection) : shootDirection;

			GameObject newObject = Instantiate<GameObject>(MainWeapon1Prefab);
			newObject.transform.position = MainWeaponMuzzle1.position;
			newObject.transform.eulerAngles = new Vector3(0f, 0f, Utils.Angle(actualBulletDirection));
			newObject.tag = "Bullet2";

			GameObject newObject2 = Instantiate<GameObject>(MainWeapon2Prefab);
			newObject.transform.position = MainWeaponMuzzle2.position;
			newObject.transform.eulerAngles = new Vector3(0f, 0f, Utils.Angle(actualBulletDirection));
			newObject.tag = "Bullet2";

			GameObject newObject3 = Instantiate<GameObject>(Battery1Prefab);
			newObject.transform.position = Battery1Muzzle.position;
			newObject.transform.eulerAngles = new Vector3(0f, 0f, Utils.Angle(actualBulletDirection));
			newObject.tag = "Bullet2";

			GameObject newObject4 = Instantiate<GameObject>(Battery2Prefab);
			newObject.transform.position = Battery2Muzzle.position;
			newObject.transform.eulerAngles = new Vector3(0f, 0f, Utils.Angle(actualBulletDirection));
			newObject.tag = "Bullet2";


			// push the created objects, but only if they have a Rigidbody2D
			Rigidbody2D rigidbody2D = newObject.GetComponent<Rigidbody2D>();
			if (rigidbody2D != null)
			{
				rigidbody2D.AddForce(actualBulletDirection * shootSpeed, ForceMode2D.Impulse);
			}

			Rigidbody2D rigidbody2D2 = newObject2.GetComponent<Rigidbody2D>();
			if (rigidbody2D2 != null)
			{
				rigidbody2D2.AddForce(actualBulletDirection * shootSpeed, ForceMode2D.Impulse);
			}

			Rigidbody2D rigidbody2D3 = newObject3.GetComponent<Rigidbody2D>();
			if (rigidbody2D3 != null)
			{
				rigidbody2D3.AddForce(actualBulletDirection * shootSpeed, ForceMode2D.Impulse);
			}

			Rigidbody2D rigidbody2D4 = newObject4.GetComponent<Rigidbody2D>();
			if (rigidbody2D4 != null)
			{
				rigidbody2D4.AddForce(actualBulletDirection * shootSpeed, ForceMode2D.Impulse);
			}

			// add a Bullet component if the prefab doesn't already have one, and assign the player ID
			BulletAttribute b = newObject.GetComponent<BulletAttribute>();
			if (b == null)
			{
				b = newObject.AddComponent<BulletAttribute>();
			}
			b.playerId = playerNumber;
			timeOfLastSpawn = Time.time;
		}*/
	}
}
