using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerContainer : NetworkBehaviour
{
    
    [SyncVar] public int teamSide;
    [SyncVar] public int tankNumber;

    [SerializeField]
    private GameObject[] _tankArray;

    [SerializeField]
    private GameObject[] _spawnPoints;

    void Start()
    {
        switch (tankNumber)
        {
            case 0:
                Network.Instantiate(_tankArray[tankNumber], _spawnPoints[teamSide].transform.position, (new Quaternion(0, 0, 0, 0)),0);
                Debug.Log("Spawn 0");
                break;
            case 1:
                Network.Instantiate(_tankArray[tankNumber], _spawnPoints[teamSide].transform.position, (new Quaternion(0, 0, 0, 0)), 0);
                Debug.Log("Spawn 1");
                break;

            case 2:
                Network.Instantiate(_tankArray[tankNumber], _spawnPoints[teamSide].transform.position, (new Quaternion(0, 0, 0, 0)), 0);
                Debug.Log("Spawn 2");
                break;
        }
        Debug.Log(teamSide + tankNumber);
    }
	
}
