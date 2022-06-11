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
	}
}
