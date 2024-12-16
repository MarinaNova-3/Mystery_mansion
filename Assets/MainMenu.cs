/* using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menuPanel;  // Reference to the menu panel
    public Button startButton;
    public Button settingsButton;
    public Button aboutButton;
    public Button quitButton;
    public Text statusText;


    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(OpenSettings);
        aboutButton.onClick.AddListener(OpenAbout);
        quitButton.onClick.AddListener(QuitGame);
            }

    void Update()
    {
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
        statusText.text = "Start Game Pressed";
        // Add logic to start the game
    }

    void OpenSettings()
    {
        statusText.text = "Settings Pressed";
        // Add logic to open settings
        SceneManager.LoadScene("SettingsScene");

    }


    void OpenAbout()
    {
        statusText.text = "About Pressed";
        // Add logic to open the about section
    }

    void QuitGame()
    {
        statusText.text = "Quit Pressed";
        // Add logic to quit the game
        Application.Quit();
    }
}
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // ���������� ��� �������� ������

public class MainMenu : MonoBehaviour
{
    public GameObject menuPanel;  // Reference to the menu panel
    public Button startButton;
    public Button settingsButton;
    public Button aboutButton;
    public Button quitButton;
    public Text statusText;

    void Start()
    {
        menuPanel.SetActive(true); // � true, ������� �� ��� ��������� ������ ���������.
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(OpenSettings);
        aboutButton.onClick.AddListener(OpenAbout);
        quitButton.onClick.AddListener(QuitGame);
    }

    void Update()
    {
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
        statusText.text = "Start Game Pressed";
        // Add logic to start the game
    }

    void OpenSettings()
    {
        statusText.text = "Settings Pressed";
        // �������� ��� ����� ��� ���������
        SceneManager.LoadScene("SettingsScene");
    }

    void OpenAbout()
    {
        statusText.text = "About Pressed";
        // Add logic to open the about section
    }

    void QuitGame()
    {
        statusText.text = "Quit Pressed";
        // �������� ��� ����������
        Application.Quit();
    }
}

