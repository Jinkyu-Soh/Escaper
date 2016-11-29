using UnityEngine;
using System.Collections;

public class SwitchZoom : MonoBehaviour {
// Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update () {
         // -------Code to switch camera between Perspective and Orthographic--------
         if (Input.GetKeyUp(KeyCode.B))
        {
            if (Camera.main.orthographic == true)
            {
                Camera.main.orthographic = false;
            }
            else
            {
                Camera.main.orthographic = true;
                Camera.main.orthographicSize = 45f;
            }
        }
    }
}
