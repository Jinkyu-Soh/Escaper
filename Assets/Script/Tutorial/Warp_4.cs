using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Warp_4 : MonoBehaviour
{

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
            originPoint.x = -100f;
            originPoint.y = 40f;
            originPoint.z = 2f;

            player.transform.position = originPoint;
        }

    }
    void OnTriggerExit(Collider other)
    {

    }

}
