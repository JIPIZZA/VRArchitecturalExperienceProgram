using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectBack : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider player)
    {

        Debug.Log("EEG");
        if (player.gameObject.name == "Player")
        {
            Debug.Log("EE");
            player.transform.position = new Vector3(53, 5, 12);
        }
    }
}
