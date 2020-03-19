using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePick : MonoBehaviour
{

    public void ScenePond()
    {
        SceneManager.LoadScene("TrackPond");
    }

    public void SceneHill()
    {
        SceneManager.LoadScene("TrackHill");
    }

    public void LoadScenePicker()
    {
        SceneManager.LoadScene("SwapScenes");
    }

}
