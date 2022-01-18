using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    public Button Play_Btn;
    public Button Quit_Btn;

    //when play button touch then load game scene
    public void Play_Game()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit_Game()
    {
        Application.Quit();
    }
}
