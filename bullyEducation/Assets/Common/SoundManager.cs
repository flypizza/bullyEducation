using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public AudioSource bg_source;
    public AudioClip normal_music;
    public AudioClip result_music;
    public string curScene = "";
    private void Awake()
    {
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
    }

    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if(SceneManager.GetActiveScene().name == "ResultScene")
        {
            bg_source.clip = result_music;
            bg_source.Play();
        }
        else
        {
            if(curScene != "MainScene")
            {
                bg_source.clip = normal_music;
                bg_source.Play();
            }
        }
        curScene = SceneManager.GetActiveScene().name;
    }
}
