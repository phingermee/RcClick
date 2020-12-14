using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]private GameObject _game;
    [SerializeField]private GameObject _menu;

    public void StartGame()
    {
        _game.gameObject.SetActive(true);
        _menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
