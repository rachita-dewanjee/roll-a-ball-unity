using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject controlsPanel;

    public GameObject instructionPanel;

    public GameObject titleText;
    public GameObject playButton;
    public GameObject controlsButton;
    public GameObject instructionsButton;
    public GameObject quitButton;

    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OpenInstructions()
    {
        titleText.SetActive(false);
        playButton.SetActive(false);
        controlsButton.SetActive(false);
        instructionsButton.SetActive(false);
        quitButton.SetActive(false);

        instructionPanel.SetActive(true);
    }

    public void CloseInstructions()
    {
        instructionPanel.SetActive(false);

        titleText.SetActive(true);
        playButton.SetActive(true);
        controlsButton.SetActive(true);
        instructionsButton.SetActive(true);
        quitButton.SetActive(true);
    }

    public void OpenControls()
    {
        titleText.SetActive(false);
        playButton.SetActive(false);
        controlsButton.SetActive(false);
        instructionsButton.SetActive(false);
        quitButton.SetActive(false);

        controlsPanel.SetActive(true);
    }

    public void CloseControls()
    {
        controlsPanel.SetActive(false);

        titleText.SetActive(true);
        playButton.SetActive(true);
        controlsButton.SetActive(true);
        instructionsButton.SetActive(true);
        quitButton.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}