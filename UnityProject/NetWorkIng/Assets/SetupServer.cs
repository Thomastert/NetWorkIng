using UnityEngine;
using System.Collections;

public class SetupServer : MonoBehaviour {
private const string typeName = "TankMoba";
private const string gameName = "Room1";
	
    // Use this for initialization
	private void StartServer()
    {
        Network.InitializeServer(2, 25000, !Network.HavePublicAddress());
        MasterServer.RegisterHost(typeName, gameName);

	}

    void OnServerInitialized()
    {
        Debug.Log("Server Initializied");
    }

    // Update is called once per frame
    void Start () {
        OnGUI();
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
