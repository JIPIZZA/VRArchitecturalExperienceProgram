using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrans : MonoBehaviour
{

    private void OnTriggerEnter(Collider player)
    {

        Debug.Log("FMP");
        if (player.gameObject.name == "Player")
        {
            Debug.Log("GBFMP");
            player.transform.position = new Vector3(53, 5, 38);
        }
    }
}
