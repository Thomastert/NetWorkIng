using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerContainer : NetworkBehaviour
{
    
    [SyncVar] public int teamSide;
    [SyncVar] public int tankNumber;


    void Start()
    {
        Debug.Log(teamSide + tankNumber);
    }
	
}
