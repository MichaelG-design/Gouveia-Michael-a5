using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseUI; // Reference to the Panel
    public Text PauseText; // Reference to the Text UI element

    private bool isPaused = false;

    void Update()
    {
        // When R is clicked, pause/resume the game
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isPaused)
            {
                // If already paused, resume the game
                ResumeGame();
            }
            else
            {
                // If not paused, pause the game
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // Freeze the game

        // Show the pause UI and text
        PauseUI.SetActive(true);
        PauseText.gameObject.SetActive(true); // Enable the Text component

        PauseText.text = "Press R to continue";
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Resume game time

        // Hide the pause UI and text
        PauseUI.SetActive(false);
        PauseText.gameObject.SetActive(false); // Disable the Text component
    }
}
