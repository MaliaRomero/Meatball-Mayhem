using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public string sceneName = "MainMenu"; // The name of the scene to be loaded

    // This function is called when the button is clicked
    public void OnButtonClick()
    {
        SceneManager.LoadScene(sceneName); // Load the specified scene
    }
}