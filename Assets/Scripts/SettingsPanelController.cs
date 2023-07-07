using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MoreMountains.Feedbacks;

public class SettingsPanelController : MonoBehaviour
{
    private int _selector = 0;
    [SerializeField]
    private GameObject[] _settingsOptions;

    private GameObject _actualOption;
    [SerializeField] private Color _selectedColor;
    [SerializeField] private Color _unselectedColor;

    [SerializeField] private GameObject[] _panels;
    bool allClosed;


    // Update is called once per frame
    void Update()
    {
        if (UIManager.uim.Escape() && allClosed)
            gameObject.SetActive(false);
        foreach (GameObject option in _panels)
        {
            if (option.activeSelf)
            {
                allClosed = false;
                if (UIManager.uim.Escape()) option.SetActive(false);
                return;
            }
            else
            {
                allClosed = true;
            }
        }

        foreach (GameObject option in _settingsOptions)
        {
            option.GetComponent<TMPro.TextMeshProUGUI>().color = _unselectedColor;
        }
        _actualOption = _settingsOptions[_selector];
        _actualOption.GetComponent<TMPro.TextMeshProUGUI>().color = _selectedColor;
        controlSelection();

    }



    private void controlSelection()
    {
        if (UIManager.uim.moveDown())
        {
            _selector++;
            if (_selector > _settingsOptions.Length - 1)
            {
                _selector = 0;
            }
        }
        if (UIManager.uim.moveUp())
        {
            _selector--;
            if (_selector < 0)
            {
                _selector = _settingsOptions.Length - 1;
            }
        }
        if (UIManager.uim.Interact())
        {
            _actualOption.GetComponent<Button>().onClick.Invoke();
        }
    }

    private void OnEnable()
    {
        UIManager.uim.SettingsActivo = true;
        print("Settings activo");
    }
    private void OnDisable()
    {
        UIManager.uim.SettingsActivo = false;
    }
}
