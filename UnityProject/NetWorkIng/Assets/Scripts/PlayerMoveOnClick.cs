using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMoveOnClick : NetworkBehaviour
{

    Vector3 newPosition;
    void Start()
    {
        newPosition = transform.position;

    }
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, 0.5f);

        if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    newPosition = hit.point;

            }
        }
        
    }
}