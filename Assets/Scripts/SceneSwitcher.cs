using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GotoScene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void GotoScene2()
    {
        SceneManager.LoadScene("Scene2");
    }
}