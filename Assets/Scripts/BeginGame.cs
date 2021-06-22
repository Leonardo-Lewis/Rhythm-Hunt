using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
//This function loads the main scene
public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //this closes the program when in a build and states "QUIT!" in the debug menu
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
