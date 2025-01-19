using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider musicSlider;
    public Slider soundSlider;
    public Dropdown languageDropdown;
    public Button backButton;

    void Start()
    {
        // Initialize sliders with default values
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
        soundSlider.value = PlayerPrefs.GetFloat("SoundVolume", 1f);

        // Add options to the dropdown
        languageDropdown.options.Clear();
        languageDropdown.options.Add(new Dropdown.OptionData("English"));
        languageDropdown.options.Add(new Dropdown.OptionData("Greek"));

        // Load saved language preference
        languageDropdown.value = PlayerPrefs.GetInt("Language", 0);

        // Add listeners for UI elements
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        soundSlider.onValueChanged.AddListener(SetSoundVolume);
        languageDropdown.onValueChanged.AddListener(ChangeLanguage);
        backButton.onClick.AddListener(BackToMainMenu);
    }

    void SetMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat("MusicVolume", volume);
        Debug.Log("Music Volume: " + volume);
        // Add logic to adjust music volume in the game
    }

    void SetSoundVolume(float volume)
    {
        PlayerPrefs.SetFloat("SoundVolume", volume);
        Debug.Log("Sound Volume: " + volume);
        // Add logic to adjust sound volume in the game
    }

    void ChangeLanguage(int index)
    {
        PlayerPrefs.SetInt("Language", index);
        Debug.Log("Language Changed to: " + languageDropdown.options[index].text);
        // Add logic to change the language of the game
    }

    void BackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    void OnDestroy()
    {
        // Save preferences when the settings menu is destroyed
        PlayerPrefs.Save();
    }
}

