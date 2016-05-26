using UnityEngine;
using System.Collections;

public class SetupServer : MonoBehaviour {
private const string typeName = "TankMoba";
private const string gameName = "TankMobaMC";
	
    // Use this for initialization
	private void StartServer()
    {
		Network.InitializeServer(5, 25002, false);
        MasterServer.RegisterHost(typeName, gameName,"Testing server setup");

	}

    void OnServerInitialized()
    {
        Debug.Log("Server Initializied");
    }
	void  OnMasterServerEvent(MasterServerEvent masterEvent)
	{
		if (masterEvent == MasterServerEvent.RegistrationSucceeded) 
		{
			Debug.Log ("Succeeded registration");
		}
	}

    // Update is called once per frame
    void Start () {
        //OnGUI();
	}

    void OnGUI()
    {
        if (!Network.isClient && !Network.isServer)
        {
            if (GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
                StartServer();
        }
    }
}
