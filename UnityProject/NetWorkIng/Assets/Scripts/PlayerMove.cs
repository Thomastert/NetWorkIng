using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            SavePos();
            // run function
        }
    }


    void SavePos()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.position = hit.point;
            }

        }
    }
}