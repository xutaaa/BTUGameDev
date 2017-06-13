using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour {

    public Transform player;
	public int numberOfStartingPlatforms;
	public GameObject Platform;
	public Vector3 platformSpawnPoint = Vector3.zero;
	public float destroyTime = 5f;

	public GameObject[] platforms;


	void Start()

	{
		int counter = 0;


		while (counter < numberOfStartingPlatforms) 
		{
			CreateNextPlatform ();
			counter = counter + 1;
		}
	}

	int pp;
	int lastPP = 0;

	void Update ()
    {
		int pp = (int) player.position.z / 50;

		if (pp > lastPP) {
			CreateNextPlatform ();
		}

		lastPP = pp;

	}

		void CreateNextPlatform()
		{
		Debug.Log ("Creating Platform");

		platformSpawnPoint.z = platformSpawnPoint.z + 50f;

		int platformChooser = Random.Range(0,platforms.Length);


		GameObject clone;

		clone = Instantiate (platforms[ platformChooser]);

		clone.transform.position = platformSpawnPoint;	

		Destroy (clone, destroyTime);

		}


}

