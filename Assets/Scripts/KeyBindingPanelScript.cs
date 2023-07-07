using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBindingPanelScript : MonoBehaviour
{
    [SerializeField] private GameObject _player1Panel;
    [SerializeField] private GameObject _player2Panel;


    // Update is called once per frame
    void Update()
    {

        if (UIManager.uim.moveLeftUp())
        {
            if (_player1Panel.activeSelf)
            {
                _player1Panel.SetActive(false);
                _player2Panel.SetActive(true);
            }
            else
            {
                _player1Panel.SetActive(true);
                _player2Panel.SetActive(false);
            }
        }
        if (UIManager.uim.moveRightUp())
        {
            if (_player1Panel.activeSelf)
            {
                _player1Panel.SetActive(false);
                _player2Panel.SetActive(true);
            }
            else
            {
                _player1Panel.SetActive(true);
                _player2Panel.SetActive(false);
            }
        }

    }
}
