using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void startscene()
    {
        Application.LoadLevel("MainScene");
    }

    public void quit()
    {
        Application.Quit();
    }
    public void menuscene()
    {
        Application.LoadLevel("MainMenu");
    }
}
