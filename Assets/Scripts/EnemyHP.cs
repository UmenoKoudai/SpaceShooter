using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[AddComponentMenu("Playground/Attributes/Health System")]
public class EnemyHP : MonoBehaviour
{
    [SerializeField] int _EnemyHp;
    [SerializeField] GameObject _Effect;
    private void Start()
    {
        
    }

    private void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            _EnemyHp--;
            if(_EnemyHp == 0)
            {
                Destroy(gameObject);
            }
            if(gameObject ! == null)
            {
                Instantiate(_Effect, this.transform.position, this.transform.rotation);
            }
        }
    }
}
