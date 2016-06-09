using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using Prototype.NetworkLobby;

public class CharacterSelect : NetworkBehaviour {

    LobbyPlayer lobbyplayer;
    // Use this for initialization
    void Start ()
    {
        if (isLocalPlayer)
        {
            lobbyplayer = GetComponent<LobbyPlayer>();
            

            //gameObject.GetComponent<Renderer>().material.color = lobbyplayer.playerColor;
            
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	//Debug.Log(lobbyplayer.playerColor);
	}
}
