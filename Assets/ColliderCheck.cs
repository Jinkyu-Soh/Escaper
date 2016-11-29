using UnityEngine;
using System.Collections;

public class ColliderCheck : MonoBehaviour {

    public bool checking;
    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            checking = true;
        }
    }
}
