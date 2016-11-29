using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

    public class Zoom : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // -------------------Code for Zooming Out------------
            if (Input.GetKey(KeyCode.Z))
            {
                if (Camera.main.fieldOfView <= 125)
                    Camera.main.fieldOfView += 2;
                if (Camera.main.orthographicSize <= 20)
                    Camera.main.orthographicSize += 0.5f;

            }
            // -------Code to switch camera between Perspective and Orthographic--------
            if (Input.GetKeyUp(KeyCode.B))
            {
                if (Camera.main.orthographic == true)
                    Camera.main.orthographic = false;
                else
                    Camera.main.orthographic = true;
            }
        }
    }

