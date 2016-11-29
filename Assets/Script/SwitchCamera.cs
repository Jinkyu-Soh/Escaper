using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {

    GameObject main_camera;
    GameObject sub_camera;

	void Start () {
        main_camera = GameObject.FindGameObjectWithTag("MainCamera");
        sub_camera = GameObject.FindGameObjectWithTag("subCamera");
        main_camera.GetComponent<Camera>().enabled = true;
        sub_camera.GetComponent<Camera>().enabled = false;
	}
	void Update () {
         if (Input.GetKeyUp(KeyCode.B))
        {
            if (main_camera.GetComponent<Camera>().enabled)
            {
                main_camera.GetComponent<Camera>().enabled = false;
                sub_camera.GetComponent<Camera>().enabled = true;
            }
            else
            {
                main_camera.GetComponent<Camera>().enabled = true;
                sub_camera.GetComponent<Camera>().enabled = false;
            }
        }
    
	}
	public void OnClickToSwitch()
	{
		if (main_camera.GetComponent<Camera>().enabled)
		{
			main_camera.GetComponent<Camera>().enabled = false;
			sub_camera.GetComponent<Camera>().enabled = true;
		}
		else
		{
			main_camera.GetComponent<Camera>().enabled = true;
			sub_camera.GetComponent<Camera>().enabled = false;
		}
	}
}





