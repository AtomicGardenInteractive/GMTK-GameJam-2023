using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUiController : MonoBehaviour
{

    [SerializeField] Button PlayBtn;
    [SerializeField] Button OptionsBtn;
    [SerializeField] Button CloseOptionsBtn;
    [SerializeField] Button ExitBtn;

    [SerializeField] GameObject OptionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        PlayBtn.onClick.AddListener(PlayPressed);
        OptionsBtn.onClick.AddListener(OptionsPressed);
        CloseOptionsBtn.onClick.AddListener(CloseOptionsPressed);
        ExitBtn.onClick.AddListener(ExitPressed);
    }

    private void PlayPressed()
    {
        SceneManager.LoadScene(1);
    }

    private void OptionsPressed()
    {
        OptionsMenu.SetActive(true);
    }

    private void CloseOptionsPressed()
    {
        OptionsMenu.SetActive(false);
    }

    private void ExitPressed()
    {
        Application.Quit();
    }

}
