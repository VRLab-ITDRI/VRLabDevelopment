using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelRumputLaut;
    public GameObject panelKeramba;
    public GameObject panelHiuPaus;
    public GameObject panelSetting;

    public GameObject btnAudioOn;
    public GameObject btnAudioOff;

    // Start is called before the first frame update
    void Start()
    {
        panelRumputLaut.SetActive(false);
        panelKeramba.SetActive(false);
        panelHiuPaus.SetActive(false);
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
        StartCoroutine(ClosePanel());
        panelRumputLaut.SetActive(true);
    }

    public void PlayRumputLaut()
    {
        SceneManager.LoadScene("1_Opening");
    }

    public void ShowKeramba()
    {
        StartCoroutine(ClosePanel());
        panelKeramba.SetActive(true);
    }

    public void PlayKeramba()
    {
        SceneManager.LoadScene("1_KerambaOpening");
    }

    public void ShowHiuPaus()
    {
        StartCoroutine(ClosePanel());
        panelHiuPaus.SetActive(true);
    }

    public void PlayHiuPaus()
    {
        SceneManager.LoadScene("1_HiuPaus");
    }

    IEnumerator ClosePanel()
    {
        panelRumputLaut.SetActive(false);
        panelKeramba.SetActive(false);
        panelHiuPaus.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }
}
