using UnityEngine;
using System.Collections;
public class Trap : MonoBehaviour
{
    void OnTriggerEnter(Collider other) { 
        if (other.gameObject.tag == "Player") 
        {
            GameObject respawn = GameObject.FindWithTag("Respawn"); 
            other.gameObject.transform.position = respawn.transform.position; 
        } 
    }
}
 