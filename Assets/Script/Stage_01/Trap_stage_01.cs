using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trap_stage_01 : MonoBehaviour {

    GameObject player;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player.transform.position.y < -10)
        {
            //게임오버 팝업 다시하기
            SceneManager.LoadScene("gameoverstage_1");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            SceneManager.LoadScene("gameoverstage_1");
        }
        else
        {

        }
    }
    void OnTriggerExit(Collider other)
    {

    }
}
