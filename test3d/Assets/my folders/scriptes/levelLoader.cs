using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelLoader : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;

    [SerializeField] private GameObject[] anyOtherUI;

    [SerializeField] private bool skipScene = false;

    [SerializeField] private int skipToIndexScene = 0;

    private Slider slider;

    private TMP_Text progressText;

    private int indexScene = 0;

    private string nameOfLevel;

    public void Start()
    {
        slider = loadingScreen.transform.Find("Slider").gameObject.GetComponent<Slider>();

        progressText = slider.transform.Find("progress text").gameObject.GetComponent<TMP_Text>();

        if(skipScene)
        {
            loadScene(skipToIndexScene);
        }
    }

    public void loadScene(int sceneIndex)
    {
        StartCoroutine(LoadWithProgres(sceneIndex));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadWithProgres(int sceneIndex)
    {
        loadingScreen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        for (int i = 0; i < anyOtherUI.Length; i++)
        {
            anyOtherUI[i].SetActive(false);
        }

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;

            progressText.text = progress * 100 + "%";

            yield return null;
        }
    }
}
