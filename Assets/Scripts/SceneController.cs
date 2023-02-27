using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneController : MonoBehaviour
{
    public string changeSceneTo;
    public float delayTime;

    [SerializeField]
    private bool isEnding = false;

    private AudioSource audios;
    public VideoPlayer videos;

    private void Start()
    {
        audios = GetComponent<AudioSource>();
    }
    
    private void Update()
    {
        if (isEnding == false)
        {
            if(!audios.isPlaying)
            {
                StartCoroutine(ChangesScene());
            }
        }
        else
        {
            if (!videos.isPlaying)
            {
                StartCoroutine(ExitScene());
            }
        }
    }

    IEnumerator ChangesScene()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(changeSceneTo);
    }

    IEnumerator ExitScene()
    {
        yield return new WaitForSeconds(2f);
        Application.Quit();
#if UNITY_EDITOR
        Debug.Log("Sudah keluar VR!");
#endif
    }
}
