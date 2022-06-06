using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyController : MonoBehaviour
{
	[Header("Object creation")]
	public GameObject MainWeapon1Prefab;
	public GameObject MainWeapon2Prefab;
	public GameObject Battery1Prefab;
	public GameObject Battery2Prefab;
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
	[SerializeField] Transform MainWeaponMuzzle1 = default;
	[SerializeField] Transform MainWeaponMuzzle2 = default;
	[SerializeField] Transform Battery1Muzzle = default;
	[SerializeField] Transform Battery2Muzzle = default;
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		m_time += Time.deltaTime;
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
		}
	}
}
