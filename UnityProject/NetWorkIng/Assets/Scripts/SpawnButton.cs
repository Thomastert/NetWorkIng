using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SpawnButton : NetworkBehaviour {
    [SerializeField]
    private Dropdown _tankChoice;
    [SerializeField]
    private Dropdown _tankColor;
    [SerializeField]
    private GameObject _playerContainerr;
	[SerializeField]
	private GameObject _serverObj;
	[SyncVar] private bool shouldIspawn = false;

	void Update()
	{
		if (Network.isServer) {
			Debug.Log ("Mi server");
		} else if (Network.isClient) {
			Debug.Log ("mi go face");
		} else {
			Debug.Log ("I am nothing");
		}
	}

	[ClientCallback]
    public void Cmd_SaveVars()
    {

			_playerContainerr.GetComponent<PlayerContainer> ().tankNumber = _tankChoice.value;
			_playerContainerr.GetComponent<PlayerContainer> ().teamSide = _tankColor.value;

			//Instantiate(_playerContainerr);
	
			//GameObject playerSelect = (GameObject)Instantiate (_playerContainerr, transform.position, transform.rotation);
			//NetworkServer.Spawn (playerSelect);
			//_serverObj.GetComponent<ServerSpawn>().Cmd_spawnObjects(_playerContainerr,transform.position,transform.rotation);

			//_playerContainerr.GetComponent<PlayerContainer> ().useCmd ();

			//shouldIspawn = true;
		Cmd_Spawn();		

		Destroy (gameObject);
	}

	[Command]
	public void Cmd_Spawn()
	{
		//NetworkConnection conn = NetworkConnection;
		GameObject ObjectToSpawn = (GameObject)Instantiate (_playerContainerr,transform.position, transform.rotation);
		//NetworkServer.ReplacePlayerForConnection (conn, ObjectToSpawn, 0);
		NetworkServer.Spawn (ObjectToSpawn);

	}
    
}
