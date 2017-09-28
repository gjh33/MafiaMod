using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to handle the loading of each screen of our app
/// A screen is largely classified as a UI with a purpose. Rule of thumb,
/// if it takes more time to make a new screen than to simply move
/// one or two UI elements, you shouldn't make a new screen and should just modify
/// the current screen
/// </summary>
public class UIController : MonoBehaviour {
    public UIScreen[] Screens;

    private void Start()
    {
        if (Screens.Length != 0)
        {
            LoadScreen(Screens[0].name);
        }
    }

    public void LoadScreen(string name)
    {
        foreach (UIScreen screen in Screens)
        {
            if (screen.name == name)
            {
                screen.canvasGO.SetActive(true);
            }
            else
            {
                screen.canvasGO.SetActive(false);
            }
        }
    }

    [System.Serializable]
    public class UIScreen
    {
        public string name;
        public GameObject canvasGO;
    }
}
