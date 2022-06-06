using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HikoukiContololler : MonoBehaviour
{
    [SerializeField] float m_speed;
	[SerializeField] Transform m_muzzle = default;@//’ePrefaboŒ»êŠÝ’è
	Rigidbody2D m_rd = default;
	[Header("Object creation")]
	AudioSource m_audio = default;
	public GameObject prefabToSpawn; //”­ŽË‚·‚é’e‚ÌPrefab‚ð“o˜^
	public KeyCode keyToPress = KeyCode.Space; //’e‚ð”­¶‚³‚¹‚éƒL[‚É‚È‚éƒ{ƒ^ƒ“
	[Header("Other options")]
	public float creationRate;
	public float shootSpeed;
	public Vector2 shootDirection = new Vector2(1f, 1f);
	public bool relativeToRotation = true;
	private float timeOfLastSpawn;
	private int playerNumber;
	float Powercount = 0;
	void Start()
    {
		timeOfLastSpawn = -creationRate;
		playerNumber = (gameObject.CompareTag("Player")) ? 0 : 1;
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
		//Power tagƒAƒCƒeƒ€‚ðŽæ‚é‚²‚Æ‚É•Ï”Powercount‚ðƒCƒ“ƒNƒŠƒƒ“ƒg
		if (collision.gameObject.tag == "Power")
		{
			Powercount++;
		}
		//•Ï”Powercount“à‚Ì”Žš‚É‚æ‚è’e‚Ì‘¬“x•Ï‰»
		if (Powercount == 0)
		{
			creationRate = .5f;
			shootSpeed = 5f;
		}
		else if (Powercount == 1)
		{
			creationRate = .3f;
			shootSpeed = 30f;
		}
		else if (Powercount == 2)
		{
			creationRate = .1f;
			shootSpeed = 50f;
		}
		else if(Powercount >= 3)
        {
			creationRate = .01f;
			shootSpeed = 50f;
		}
	}
    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Power")
        {
			Powercount++;
        }
		if(Powercount == 0)
        {
			creationRate = .5f;
			shootSpeed = 5f;
		}
		else if(Powercount == 1)
		{
			creationRate = .3f;
			shootSpeed = 30f;
		}
		else if (Powercount >= 2)
		{
			creationRate = .1f;
			shootSpeed = 50f;
		}
	}*/
}
