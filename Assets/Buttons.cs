using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame()
    {
        // Load the main game scene, replace "GameScene" with the actual name of your game scene
        SceneManager.LoadScene("GameScene");
    }

    // Function to exit the game
    public void ExitGame()
    {
        // Exit the application
        Application.Quit();

        // Note: This will only work in a built application, not in the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
