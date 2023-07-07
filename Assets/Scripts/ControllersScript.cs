using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllersScript : MonoBehaviour
{

    [SerializeField] private int depth = 0;
    [SerializeField] private int maxDepth;
    [SerializeField] private GameObject[] _keyObjectsRace;
    [SerializeField] private GameObject[] _keyObjectsStore;
    [SerializeField] private Color _selectedColor;
    [SerializeField] private Color _unselectedColor;
    [SerializeField] private Color _selectedColorButton;
    [SerializeField] private Color _unselectedColorButton;
    [SerializeField]
    private GameObject _activeGameObject;
    [SerializeField] private GameObject isBinding => UIManager.uim.IsBinding;
    [SerializeField]
    private Button[] _buttons;
    private int _selectedButton = 0;

    private Button[] _previousButtons;
    private void Update()
    {
        depthOfControllers();
        ChangeDepth();

    }

    private void ChangeDepth()
    {

        if (UIManager.uim.moveUp())
        {
            if (depth == 0)
            {
                depth = maxDepth;
            }
            else
            {
                depth--;
                if (depth != 0)
                {
                    deSelectAll();
                    SelectKeyToChange();

                }
                clearPreviousButtons();
                if (_activeGameObject == null) return;
                _buttons = _activeGameObject.GetComponentsInChildren<Button>();
                _previousButtons = _buttons;
                if (_buttons.Length == 1)
                {
                    _selectedButton = 0;
                }

            }
        }
        if (UIManager.uim.moveDown())
        {

            if (depth == maxDepth)
                depth = 0;
            else
            {
                depth++;
                if (depth != 0)
                {
                    deSelectAll();
                    SelectKeyToChange();

                }
                clearPreviousButtons();
                if (_activeGameObject == null) return;
                _buttons = _activeGameObject.GetComponentsInChildren<Button>();
                _previousButtons = _buttons;
                if (_buttons.Length == 1)
                {
                    _selectedButton = 0;
                }

            }
        }
    }
    private void depthOfControllers()
    {
        clearSelection();
        if (depth == 0)
        {
            clearAllButtons();
            deSelectAll();
            ChangeTypeOfControllers();
        }
        else
        {
            AccionarBoton();
            ChangeSelectedButton();
            SetInactive();
        }
    }
    private void AccionarBoton()
    {
        if (UIManager.uim.Interact())
        {
            if (_buttons.Length > 0)
                _buttons[_selectedButton].onClick.Invoke();

        }
    }
    private void ChangeSelectedButton()
    {

        if (UIManager.uim.moveLeft())
        {

            _selectedButton--;
            if (_selectedButton < 0)
            {
                _selectedButton = _buttons.Length - 1;
            }
        }
        else if (UIManager.uim.moveRight())
        {
            _selectedButton++;
            if (_selectedButton > _buttons.Length - 1)
            {
                _selectedButton = 0;
            }
        }
    }

    private void SelectKeyToChange()
    {
        if (_selectedRS == 0)
        {
            for (int i = 0; i < _keyObjectsRace.Length; i++)
            {
                if (i == depth - 1)
                {
                    _keyObjectsRace[i].GetComponent<UnityEngine.UI.Image>().color = _selectedColor;
                    _activeGameObject = _keyObjectsRace[i];
                }
                else
                {
                    _keyObjectsRace[i].GetComponent<UnityEngine.UI.Image>().color = _unselectedColor;
                }
            }
        }
        else
        {

            for (int i = 0; i < _keyObjectsStore.Length; i++)
            {
                if (i == depth - 1)
                {
                    _keyObjectsStore[i].GetComponent<UnityEngine.UI.Image>().color = _selectedColor;
                    _activeGameObject = _keyObjectsStore[i];
                }
                else
                {
                    _keyObjectsStore[i].GetComponent<UnityEngine.UI.Image>().color = _unselectedColor;
                }
            }
        }
    }
    private void clearSelection()
    {
        if (_buttons.Length > 0)
        {
            clearAllButtons();
            for (int i = 0; i < _buttons.Length; i++)
            {
                if (i == _selectedButton)
                    _buttons[i].gameObject.GetComponent<UnityEngine.UI.Image>().color = _selectedColorButton;
            }
        }
    }
    private void deSelectAll()
    {
        foreach (var item in _keyObjectsRace)
        {
            item.GetComponent<UnityEngine.UI.Image>().color = _unselectedColor;

        }
        foreach (var item in _keyObjectsStore)
        {
            item.GetComponent<UnityEngine.UI.Image>().color = _unselectedColor;
        }
    }
    private void clearPreviousButtons()
    {
        if (_previousButtons == null) return;
        foreach (var item in _previousButtons)
        {
            item.gameObject.GetComponent<UnityEngine.UI.Image>().color = _unselectedColorButton;
        }
    }
    private void clearAllButtons()
    {
        if (_buttons == null) return;
        foreach (var item in _buttons)
        {
            item.gameObject.GetComponent<UnityEngine.UI.Image>().color = _unselectedColorButton;
        }
    }
    private int changeHorizontal(int horizontal, int max)
    {
        if (UIManager.uim.moveRight() && horizontal < max)
        {
            horizontal++;
        }
        if (UIManager.uim.moveLeft() && horizontal > 0)
        {
            horizontal--;
        }
        return horizontal;
    }
    #region Seleccionar controles de carrera o de la tienda
    [SerializeField] private GameObject[] _selectRace;
    [SerializeField] private GameObject[] _selectStore;
    [SerializeField] private int _selectedRS;
    private void RaceSelected()
    {
        _selectRace[0].SetActive(false);
        _selectRace[1].SetActive(true);
        _selectStore[0].SetActive(true);
        _selectStore[1].SetActive(false);
    }
    private void StoreSelected()
    {
        _selectRace[0].SetActive(true);
        _selectRace[1].SetActive(false);
        _selectStore[0].SetActive(false);
        _selectStore[1].SetActive(true);
    }
    private void SetInactive()
    {
        _selectRace[0].SetActive(true);
        _selectRace[1].SetActive(false);
        _selectStore[0].SetActive(true);
        _selectStore[1].SetActive(false);
    }

    private void ChangeTypeOfControllers()
    {
        _selectedRS = changeHorizontal(_selectedRS, 1);
        if (_selectedRS == 0)
        {
            maxDepth = _keyObjectsRace.Length;
            RaceSelected();
        }
        else
        {
            maxDepth = _keyObjectsStore.Length;
            StoreSelected();
        }
    }

    #endregion

}
