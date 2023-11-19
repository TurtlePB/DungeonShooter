using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject settignsPanel;
    public void StartGame()
    {
        SceneManager.LoadScene("HUB");
    }

    public void OpenSettings()
    {
        settignsPanel.SetActive(true);
    }
    
    public void CloseSettings()
    {
        settignsPanel.SetActive(false);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

}
