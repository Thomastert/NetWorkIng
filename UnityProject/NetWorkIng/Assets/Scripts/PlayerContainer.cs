using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerContainer : NetworkBehaviour
{
	
    [SyncVar] public int teamSide;
    [SyncVar] public int tankNumber;
	[SyncVar] public bool canISpawn = false;

    [SerializeField]
    private GameObject[] _tankArray;

    [SerializeField]
    private GameObject[] _spawnPoints;

	[ClientCallback]
	public void useCmd()
	{
		Cmd_CheckForTank ();
	}
	[Command]
	public void Cmd_CheckForTank()
	{
		Debug.Log ("spawning in progres");
        switch (tankNumber)
        {
		case 0:
			Debug.Log ("Spawned tank1");
			GameObject obj1 = (GameObject)Instantiate (_tankArray [tankNumber], _spawnPoints [teamSide].transform.position, (new Quaternion (0, 0, 0, 0)));
			Debug.Log ("Spawn 0");
			NetworkServer.SpawnWithClientAuthority (obj1, connectionToClient);
                break;
            case 1:
			GameObject obj2 = (GameObject)Instantiate(_tankArray[tankNumber], _spawnPoints[teamSide].transform.position, (new Quaternion(0, 0, 0, 0)));
                Debug.Log("Spawn 1");
			NetworkServer.SpawnWithClientAuthority (obj2, connectionToClient);
                break;
		
            case 2:
			GameObject obj3 = (GameObject) Instantiate(_tankArray[tankNumber], _spawnPoints[teamSide].transform.position, (new Quaternion(0, 0, 0, 0)));
                Debug.Log("Spawn 2");
			NetworkServer.SpawnWithClientAuthority (obj3, connectionToClient);
                break;
        }
        Debug.Log(teamSide + tankNumber);
		//canISpawn = false;
    }
	
}
