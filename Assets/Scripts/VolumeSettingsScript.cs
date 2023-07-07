using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettingsScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _volumeBars;
    [SerializeField] private Color _activeColor;
    private int pos = 0;
    [SerializeField] private Slider actualSlider;

    private void Update()
    {
        mostrarSeleccionado();
        cambiarPosicion();
        cambiarValor();
    }

    private void mostrarSeleccionado()
    {
        foreach (var item in _volumeBars)
        {
            item.GetComponent<Image>().color = new Color(1, 1, 1, 0f);
        }
        _volumeBars[pos].GetComponent<Image>().color = _activeColor;
    }

    private void cambiarPosicion()
    {
        if (UIManager.uim.moveDown() && pos < _volumeBars.Length - 1)
        {
            pos++;
        }
        else if (UIManager.uim.moveUp() && pos > 0)
        {
            pos--;
        }
    }

    private void cambiarValor()
    {
        actualSlider = _volumeBars[pos].GetComponentInChildren<Slider>();
        if (UIManager.uim.moveRight() && actualSlider.value < 1)
        {
            actualSlider.value += 0.1f;
        }
        else if (UIManager.uim.moveLeft() && actualSlider.value > 0)
        {
            actualSlider.value -= 0.1f;
        }
    }
}
