using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class RebindingDisplay : MonoBehaviour
{
    [SerializeField] private InputActionReference _actionReference;
    [SerializeField] private TMPro.TMP_Text _text;
    [SerializeField] private GameObject _startRebindingObject;
    [SerializeField] private GameObject _waitingForInputObject;

    public void StartRebinding()
    {
        _startRebindingObject.SetActive(false);
        _waitingForInputObject.SetActive(true);

    }

}
