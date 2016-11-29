using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clear_stage_01 : MonoBehaviour {
    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            SceneManager.LoadScene("clearstage_1");
        }

    }
    void OnTriggerExit(Collider other)
    {

    }
}
