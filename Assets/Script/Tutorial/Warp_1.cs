using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Warp_1 : MonoBehaviour {

    GameObject player;
    Vector3 originPoint1 = new Vector3();
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (player.transform.position.y < -10)
        {
            SceneManager.LoadScene("tutorial_1");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            originPoint1.x = 20f;
            originPoint1.y = 10f;
            originPoint1.z = 25f;
            player.transform.position = originPoint1;
        }
    }
    void OnTriggerExit(Collider other)
    {

    }
}



