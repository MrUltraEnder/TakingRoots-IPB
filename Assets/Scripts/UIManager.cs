using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _dineroPlayer1;
    [SerializeField] private TMP_Text _dineroPlayer2;
    [SerializeField] private TMP_Text _LapsCount;
    public static UIManager uim;
    public PlayerInput myInputs1;
    public PlayerInput myInputs2;
    public GameObject Player1Select;
    public GameObject Player2Select;
    public GameObject Canvas;

    [Header("Panel de seleccion")]
    public GameObject PrefabP1;
    public GameObject PrefabP2;
    public List<GameObject> SeleccionDeVerduras;
    [SerializeField] private GameObject PanelSeleccion;
    public static int posP1;
    public static int posP2;
    private bool _pantallaDeSeleccion = true;
    [SerializeField] private TimerUI1 timer;

    ////////////////////////////
    [Header("Pausa")]
    public UnityEvent OnPause;
    public UnityEvent OnResume;
    [SerializeField] private TextMeshProUGUI[] _selectButtons;
    [SerializeField] private TMP_ColorGradient _selected;
    int selected = 0;
    private bool statePause => GameManager.gm.gameState == GameState.Pause;
    private bool _inLobby => GameManager.gm.gameState == GameState.Lobby;
    private bool _inStore => GameManager.gm.gameState == GameState.Store;
    public GameObject IsBinding;

    ////////////////////////////
    [Header("Debug")]
    [SerializeField] private Vector2 Movimiento;
    [SerializeField] bool _inTest;

    public bool SettingsActivo = false;
    private void Awake()
    {
        uim = this;

    }
    void Start()
    {
        posP1 = 0;
        if (_inTest) return;
        Player1Select = Instantiate(PrefabP1, SeleccionDeVerduras[posP1].transform.position, Quaternion.identity, Canvas.transform);
        Player2Select = Instantiate(PrefabP2, SeleccionDeVerduras[posP2].transform.position, Quaternion.identity, Canvas.transform);
        GameManager.gm.StartSelection();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inTest) return;

        if (SettingsActivo) return;
        if (Interact()) ActivarBoton();
        Pause();
        if (statePause) _selectionPause();
        if (_inLobby || _inStore)
        {
            _pantallaDeSeleccion = false;

        }
        if (!_pantallaDeSeleccion)
            return;
        if (timer.tiempo > 0)
        {
            VegetalSelectionPhase();
        }
        else
        {
            GameManager.gm.StartGame();
            GameManager.gm.spawnPlayers();
            PanelSeleccion.SetActive(false);
            _pantallaDeSeleccion = false;
        }

    }

    public void Pause()
    {

        if (_inLobby || _inStore)
        {
            if (Escape())
            {
                PauseUI();
            }
        }
        else if (statePause)
        {
            if (Escape())
            {
                Resume();
            }
        }

    }
    private void _selectionPause()
    {
        foreach (var item in _selectButtons)
        {
            if (_selectButtons[selected] != item)
            {
                item.colorGradientPreset = null;
            }
        }
        _selectButtons[selected].colorGradientPreset = _selected;
        if (moveUp())
        {
            selected--;
            if (selected < 0)
            {
                selected = _selectButtons.Length - 1;
            }
        }
        else if (moveDown())
        {
            selected++;
            if (selected > _selectButtons.Length - 1)
            {
                selected = 0;
            }
        }

    }
    public bool Interact()
    {
        if (myInputs1.actions["Interaction"].WasPressedThisFrame())
        {
            return true;
        }
        return false;
    }
    private void ActivarBoton()
    {
        _selectButtons[selected].GetComponent<Button>().onClick.Invoke();
    }
    public void Resume()
    {
        GameManager.gm.ResumeGameManager();
        OnResume.Invoke();
    }
    public void Quit()
    {
        Application.Quit();
    }
    private void PauseUI()
    {
        OnPause.Invoke();
        GameManager.gm.PauseGameManager();
    }

    public void _dineroPlayer1UI(int dinero)
    {
        _dineroPlayer1.text = "$" + dinero.ToString();
    }
    public void _dineroPlayer2UI(int dinero)
    {
        _dineroPlayer2.text = "$" + dinero.ToString();
    }
    public void SetLapsCount(int laps)
    {
        _LapsCount.text = laps.ToString() + "/3";
    }

    #region input Management

    public bool moveUp()
    {
        if (myInputs1.actions["Movement"].WasPressedThisFrame())
        {
            if (myInputs1.actions["Movement"].ReadValue<Vector2>().y > 0.5f)
            {

                return true;
            }
        }
        return false;
    }
    public bool moveDown()
    {
        if (myInputs1.actions["Movement"].WasPressedThisFrame())
        {
            if (myInputs1.actions["Movement"].ReadValue<Vector2>().y < -0.5f)
            {

                return true;
            }
        }
        return false;
    }
    public bool moveLeft()
    {
        if (myInputs1.actions["Movement"].WasPressedThisFrame())
        {
            if (myInputs1.actions["Movement"].ReadValue<Vector2>().x < -0.5f)
            {

                return true;
            }
        }
        return false;
    }
    public bool moveRight()
    {
        if (myInputs1.actions["Movement"].WasPressedThisFrame())
        {
            if (myInputs1.actions["Movement"].ReadValue<Vector2>().x > 0.5f)
            {

                return true;
            }
        }
        return false;
    }
    public bool moveLeftUp()
    {
        if (myInputs1.actions["LeffQ"].WasPressedThisFrame())
        {
            return true;
        }
        return false;
    }
    public bool moveRightUp()
    {
        if (myInputs1.actions["RightE"].WasPressedThisFrame())
        {
            return true;
        }
        return false;
    }
    public bool Escape()
    {
        if (myInputs1.actions["Salir"].WasPressedThisFrame())
        {
            return true;
        }
        return false;
    }
    #endregion
    public void VegetalSelectionPhase()
    {

        if (myInputs1.actions["Right"].WasPressedThisFrame())
        {
            posP1++;
            if (posP1 > 2)
            {
                posP1 = 0;
            }
            Player1Select.transform.position = SeleccionDeVerduras[posP1].transform.position;
        }
        if (myInputs1.actions["Left"].WasPressedThisFrame())
        {
            posP1--;
            if (posP1 < 0)
            {
                posP1 = 2;
            }
            Player1Select.transform.position = SeleccionDeVerduras[posP1].transform.position;
        }
        if (myInputs2.actions["Right"].WasPressedThisFrame())
        {
            posP2++;
            if (posP2 > 2)
            {
                posP2 = 0;
            }
            Player2Select.transform.position = SeleccionDeVerduras[posP2].transform.position;
        }
        if (myInputs2.actions["Left"].WasPressedThisFrame())
        {
            posP2--;
            if (posP2 < 0)
            {
                posP2 = 2;
            }
            Player2Select.transform.position = SeleccionDeVerduras[posP2].transform.position;
        }
    }

}
