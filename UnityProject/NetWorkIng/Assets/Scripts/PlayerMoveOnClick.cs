using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMoveOnClick : NetworkBehaviour
{
	[SyncVar] private Vector3 _syncPos;
	[SerializeField]private Transform _myTransform;

    void FixedUpdate()
    {
		TransmitPos ();
		LerpPosition ();


    }
	void LerpPosition()
	{
		if (!isLocalPlayer)
		{
			return;
		}
		_myTransform.position = Vector3.Lerp(_myTransform.position, _syncPos, 15);

		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				//newPosition = hit.point;
				CmdProvidePositionToServer(hit.point);
			}
		}


	}
	[Command]
	void CmdProvidePositionToServer(Vector3 pos)
	{
		_syncPos = pos;
	}
	[ClientCallback]
	void TransmitPos()
	{
		CmdProvidePositionToServer (_myTransform.position);
	}
}