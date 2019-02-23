using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{

    public Light scene_light;
    bool isDay = true;

    public GameObject snow;

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

    public void SwitchNight()
    {
        if (isDay)
        {
            scene_light.intensity = 0.2F;
        }
        else
        {
            scene_light.intensity = 1F;
        }
        isDay = !isDay;
    }

    public void SwitchSnow()
    {
        ParticleSystem snowPC = snow.GetComponent<ParticleSystem>();

        if (snowPC.isEmitting)
        {
            snowPC.Stop();
        }
        else
        {
            snowPC.Play();
        }

    }
}