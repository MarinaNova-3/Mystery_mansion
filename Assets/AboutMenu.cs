using UnityEngine;
using UnityEngine.UI;

public class AboutMenu : MonoBehaviour
{
    public Button backButton;

    void Start()
    {
        // Add the button listener to go back to the main menu
        backButton.onClick.AddListener(BackToMainMenu);
    }

    void BackToMainMenu()
    {
        // Load the MainScene when the back button is clicked
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
}
