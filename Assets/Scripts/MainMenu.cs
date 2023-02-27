using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelRumputLaut;
    public GameObject panelSetting;

    public GameObject btnAudioOn;
    public GameObject btnAudioOff;

    public string loadSceneName;

    // Start is called before the first frame update
    void Start()
    {
        panelRumputLaut.SetActive(false);
        panelSetting.SetActive(false);
        btnAudioOn.SetActive(true);
        btnAudioOff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowSetting()
    {
        panelSetting.SetActive(true);
    }

    public void CloseSetting()
    {
        panelSetting.SetActive(false);
    }

    public void MuteToogle(bool muted)
    {
        if (muted)
        {
            btnAudioOn.SetActive(false);
            AudioListener.volume = 0f;
            btnAudioOff.SetActive(true);
        }
        else
        {
            btnAudioOff.SetActive(false);
            AudioListener.volume = 1f;
            btnAudioOn.SetActive(true);
        }
    }

    public void ShowRumputLaut()
    {
        panelRumputLaut.SetActive(true);
    }

    public void PlayRumputLaut()
    {
        SceneManager.LoadScene(loadSceneName);
    }
}
