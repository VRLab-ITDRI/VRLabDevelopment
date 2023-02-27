using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUp : MonoBehaviour
{
    public GameObject frame;
    public AudioSource audios;
    public string nextSceneName;

    // Start is called before the first frame update
    void Start()
    {
        frame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!audios.isPlaying)
        {
            frame.SetActive(true);
        }
    }

    public void ShowPopUp()
    {
        frame.SetActive(true);
    }

    public void ClosePopUp()
    {
        frame.SetActive(false);
    }

    public void NextScene()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nextSceneName);
    }
}
