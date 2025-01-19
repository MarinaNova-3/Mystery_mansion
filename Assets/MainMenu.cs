using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menuPanel;       // Reference to the menu panel
    public Button startButton;
    public Button settingsButton;
    public Button aboutButton;
    public Button quitButton;

    void Start()
    {
        // Assign button listeners
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(OpenSettings);
        aboutButton.onClick.AddListener(OpenAbout);
        quitButton.onClick.AddListener(QuitGame);

        // Make sure the menu panel is active
        menuPanel.SetActive(true);
    }

    void Update()
    {
        // Toggle the menu with the Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
    }

    void StartGame()
    {
        Debug.Log("Starting Game...");
    }

    void OpenSettings()
    {
        Debug.Log("Opening Settings...");
        SceneManager.LoadScene("SettingsScene"); // Load the Settings scene
    }

    void OpenAbout()
    {
        Debug.Log("Opening About Section...");
        SceneManager.LoadScene("AboutScene"); // Load the About scene
    }

    void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
