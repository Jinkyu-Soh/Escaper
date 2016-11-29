using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Warp_3 : MonoBehaviour {
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
            SceneManager.LoadScene("tutorial_1");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Vector3 originPoint = new Vector3();
            originPoint.x = 20f;
            originPoint.y = 10f;
            originPoint.z = 46f;

            player.transform.position = originPoint;
        }

    }
    void OnTriggerExit(Collider other)
    {

    }

}
