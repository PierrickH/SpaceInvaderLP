using UnityEngine;
using System.Collections;

public class InvadersManager : MonoBehaviour
{
	private Transform[] Invaders;

	private Transform invader;
	public Transform invader1Prefab;
	public Transform invader2Prefab;
	public Transform invader3Prefab;

	private bool goingRight;



	// Use this for initialization
	void Start ()
	{
		Invaders = new Transform[55];
		int index = 0;
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 11; j++)
			{
				if (i < 1)
				{
					invader = Instantiate (invader3Prefab) as Transform;
					Invaders[index]= invader;
					invader.transform.position = new Vector3 (j * 2.3f - 3.5f, i * 2.3f, 3);
					index = index+1;
				}
				if (i >= 1 && i < 3)
				{
					invader = Instantiate (invader2Prefab) as Transform;
					Invaders[index]= invader;
					invader.transform.position = new Vector3 (j * 3.3f - 4.5f, i * 3.3f, 4);
					index = index+1;
				}
				if (i >= 3)
				{
					invader = Instantiate (invader1Prefab) as Transform;
					Invaders[index]= invader;
					invader.transform.position = new Vector3 (j * 5.3f - 6.5f, i * 5.3f, 6);
					index = index+1;
				}
			}
		}
	}

	
	// Update is called once per frame
	void Update ()
	{

	}

	public void moveInvadersCloser ()
	{

	}

	public void destroyInvader (Transform invader)
	{

	}
}
