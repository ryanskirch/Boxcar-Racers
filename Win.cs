using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject TrackButton;

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("BoxCar").SendMessage("Finish");
        TrackButton.gameObject.SetActive(true);
  
    }

    public void LoadScenePicker()
    {
        SceneManager.LoadScene("SwapScenes");
    }
   

}
