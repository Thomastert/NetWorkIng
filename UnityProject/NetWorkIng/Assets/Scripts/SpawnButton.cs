using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SpawnButton : NetworkBehaviour {
    [SerializeField]
    private Dropdown TankChoice;
    [SerializeField]
    private Dropdown TankKleur;
	
    // Use this for initialization
	void Start () {

        //if (isLocalPlayer)
        //{
        //    gameObject.SetActive(true);
        //}
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(TankChoice.value);
	}
}
