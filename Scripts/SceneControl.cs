using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControl : MonoBehaviour
{
    public GameObject[] button;
    public GameObject[] progressBar;

    public Slider[] slider;

    public Texture2D _cursorSprite;

    private GameObject currentButton, currentProgressBar;

    private Slider currentSlider;

    private float progress;

    private void Start()
    {
        Cursor.SetCursor(_cursorSprite, new Vector2(10, 5), CursorMode.ForceSoftware);
    }   

    public void OpenMainModelScene()
    {
        currentButton = button[0];
        currentProgressBar = progressBar[0];
        currentSlider = slider[0];
        StartCoroutine(LoadAsync("MainModel"));
    }

    public void OpenAnimationsScene()
    {
        currentButton = button[1];
        currentProgressBar = progressBar[1];
        currentSlider = slider[1];
        StartCoroutine(LoadAsync("AnimationsScene"));
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OpenPartScene(string scenePartName)
    {
        SceneManager.LoadScene(scenePartName);
    }

    public void OpenMainModelFromPart()
    {
        SceneManager.LoadScene("MainModel");
    }

    public void OpenMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator LoadAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        currentButton.SetActive(false);
        currentProgressBar.SetActive(true);

        while (!operation.isDone)
        {
            progress = Mathf.Clamp01(operation.progress / 0.9f);
            currentSlider.value = progress;
            yield return null;
        }
    }
}
