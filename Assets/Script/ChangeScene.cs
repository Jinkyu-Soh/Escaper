using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void SceneChange_main_2()
    {
        SceneManager.LoadScene("main_2");
    }
    public void SceneChange_tutorial_1()
    {
        SceneManager.LoadScene("tutorial_1");
    }
    public void SceneChange_selectgame()
    {
        SceneManager.LoadScene("select_stage");
    }
    public void SceneChange_playgame_1()
    {
        SceneManager.LoadScene("map");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
