using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClearTutorial : MonoBehaviour {
    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            SceneManager.LoadScene("main_2");
        }

    }
    void OnTriggerExit(Collider other)
    {

    }
}
