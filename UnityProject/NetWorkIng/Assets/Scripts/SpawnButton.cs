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

	[Command]
    public void Cmd_SaveVars()
    {

        _playerContainerr.GetComponent<PlayerContainer>().tankNumber = _tankChoice.value;
        _playerContainerr.GetComponent<PlayerContainer>().teamSide = _tankColor.value;
        //Instantiate(_playerContainerr);
		NetworkServer.SpawnWithClientAuthority(_playerContainerr, connectionToClient);


		_playerContainerr.GetComponent<PlayerContainer> ().useCmd ();
		Destroy (gameObject);
		}
    
}
