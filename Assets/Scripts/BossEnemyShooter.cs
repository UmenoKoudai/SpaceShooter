using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyShooter : MonoBehaviour
{
    [SerializeField] GameObject _mainweapon1;
    [SerializeField] GameObject _mainweapon2;
    [SerializeField] GameObject _sabweapon1;
    [SerializeField] GameObject _sabweapon2;
    [SerializeField] Transform _mainweapon1position;
    [SerializeField] Transform _mainweapon2position;
    [SerializeField] Transform _sabweapon1position;
    [SerializeField] Transform _sabweapon2position;
    [SerializeField] float _interval = 1f;
    float _timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer > _interval)
        {
            Instantiate(_mainweapon1, _mainweapon1position.position,transform.rotation);
            Instantiate(_mainweapon2, _mainweapon2position.position, transform.rotation);
            Instantiate(_sabweapon1, _sabweapon1position.position, transform.rotation);
            Instantiate(_sabweapon2, _sabweapon2position.position, transform.rotation);
        }
    }
}
