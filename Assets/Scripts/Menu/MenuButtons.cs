using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Skins;
    
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToSettings()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(true);
    }

    public void GoToMainMenu()
    {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        Skins.SetActive(false);
    }

    public void GoToSkins()
    {
        MainMenu.SetActive(false);
        Skins.SetActive(true);
    }
}
