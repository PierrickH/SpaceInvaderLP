using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{
	/// <summary>
	/// The bullet prefab.
	/// </summary>
	public Transform bulletPrefab;
	private Transform bullet;
	private Transform bullet2;
	private Transform bullet3;
	private Transform bullet4;
	private Transform bullet5;
	private GUIText livesLabel;

	// Use this for initialization
	void Start ()
	{
		livesLabel = GameObject.Find("LivesLabel").guiText;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Left movement
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-70 * Time.deltaTime, 0, 0);
		}
		// Right movement
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(70 * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.Space))
		{
			shoot ();
		}
	}

	private void shoot()
	{
		bullet = Instantiate (bulletPrefab) as Transform;
		bullet.transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
		bullet.rigidbody2D.velocity = new Vector2 (0f, 99f);

		bullet2 = Instantiate (bulletPrefab) as Transform;
		bullet2.transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
		bullet2.rigidbody2D.velocity = new Vector2 (7f, 100f);

		bullet3 = Instantiate (bulletPrefab) as Transform;
		bullet3.transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
		bullet3.rigidbody2D.velocity = new Vector2 (-7f, 100f);

		bullet4 = Instantiate (bulletPrefab) as Transform;
		bullet4.transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
		bullet4.rigidbody2D.velocity = new Vector2 (14f, 101f);

		bullet5 = Instantiate (bulletPrefab) as Transform;
		bullet5.transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
		bullet5.rigidbody2D.velocity = new Vector2 (-14f, 101f);

	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.collider.CompareTag("Invader"))
		{
			Destroy(collision.collider.gameObject);
			transform.position = new Vector3(0, transform.position.y, 0);
		}
	}
}
