using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class ServerSpawn : NetworkBehaviour {

	void Update()
	{


	}
	[Command]
	public void Cmd_spawnObjects(GameObject toSpawn, Vector3 spawnPoint, Quaternion rotation)
	{
		Debug.Log ("I Spawn");
		GameObject ObjectToSpawn = (GameObject)Instantiate (toSpawn, spawnPoint, rotation);
		//NetworkServer.Spawn (ObjectToSpawn);

	}
}
