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
	[Header("creation position")]
	[SerializeField] Transform _mainweapon1position;
	[SerializeField] Transform _mainweapon2position;
	[SerializeField] Transform _sabweapon1position;
	[SerializeField] Transform _sabweapon2position;
	[Header("Other options")]
	[SerializeField] float m_interval = 1;
	float m_time;
	void Start()
    {
		

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
