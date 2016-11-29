using UnityEngine;
using System.Collections;

public class Button_Event : MonoBehaviour {

    GameObject player;
    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            Vector3 originPoint = new Vector3();
            originPoint.x = 195f;
            originPoint.y = 10f;
            originPoint.z = 202f;

            player.transform.position = originPoint;
        }
        
    }
    void OnTriggerExit(Collider other)
    {

    }
}
