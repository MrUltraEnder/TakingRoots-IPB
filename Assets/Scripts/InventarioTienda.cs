using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System.Linq;
using UnityEngine.UI;
using MoreMountains.Feedbacks;
public class InventarioTienda : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dinero;
    [SerializeField] private Slider _slider;
    [SerializeField] private InventoryScriptableObject inventorySO;

    [SerializeField] private TextMeshProUGUI textoInventario;

    [Header("Bandeja de vegetales")]
    [SerializeField] private Transform _nabosTransform;
    [SerializeField] private Transform _rabanosTransform;
    [SerializeField] private Transform _papasTransform;
    [SerializeField] private Sprite nabo;
    [SerializeField] private Sprite rabano;
    [SerializeField] private Sprite papa;
    [SerializeField] private GameObject prefabUIVegetal;

    [Header("Inventario")]
    [SerializeField] private TextMeshProUGUI _CantidadNabos;
    [SerializeField] private TextMeshProUGUI _CantidadRabanos;
    [SerializeField] private TextMeshProUGUI _CantidadPapas;
    private Dictionary<string, int> bandejaVegetales = new Dictionary<string, int>();

    private PlayerInput myInputs;
    [SerializeField] private string playerID;

    [Header("Feedbacks")]
    [SerializeField] private MMF_Player _Campana;
    [SerializeField] private MMF_Player _RecibirDinero;
    [SerializeField] private MMF_Player _Error;
    [SerializeField] private MMF_Player _Correct;


    private void Start()
    {
        InitializeBandeja();

        myInputs = GetComponent<PlayerInput>();
        ActualizarInventario();
    }

    private void Update()
    {
        _slider.value = inventorySO.Dinero;
        if (GameManager.gm.gameState == GameState.Pause)
            return;

        if (myInputs.actions["Place Potatoe"].WasPressedThisFrame())
        {
            AddVegetal("papa", ref inventorySO.NumeroPapas);
        }
        if (myInputs.actions["Place Radish"].WasPressedThisFrame())
        {
            AddVegetal("rábano", ref inventorySO.NumeroRabanos);
        }
        if (myInputs.actions["Place Turnip"].WasPressedThisFrame())
        {
            AddVegetal("nabo", ref inventorySO.NumeroNabos);
        }
        if (myInputs.actions["Deliver Tray"].WasPressedThisFrame())
        {
            RestarVegetales();
        }
        if (myInputs.actions["Skip"].WasPressedThisFrame())
        {
            FindObjectOfType<NpcManager>().skipear(playerID);
            _Campana.PlayFeedbacks();
        }

        dinero.text = inventorySO.Dinero.ToString() + "$";
    }

    private void ActualizarInventario()
    {
        _CantidadNabos.text = "x" + inventorySO.NumeroNabos.ToString();
        _CantidadRabanos.text = "x" + inventorySO.NumeroRabanos.ToString();
        _CantidadPapas.text = "x" + inventorySO.NumeroPapas.ToString();
    }
    private void InitializeBandeja()
    {
        bandejaVegetales.Add("papa", 0);
        bandejaVegetales.Add("rábano", 0);
        bandejaVegetales.Add("nabo", 0);
    }



    private void AddVegetal(string vegetal, ref int count)
    {
        if ((count - bandejaVegetales[vegetal]) > 0)
        {
            bandejaVegetales[vegetal]++;
            AddVegetalBandejaUI(vegetal);

        }
        else
        {
            Debug.Log($"No tienes {vegetal}s");
        }
    }
    private void AddVegetalBandejaUI(string vegetal)
    {
        GameObject vegetalUI;
        switch (vegetal)
        {
            case "papa":
                vegetalUI = Instantiate(prefabUIVegetal, _papasTransform.position, Quaternion.identity, _papasTransform);
                vegetalUI.GetComponent<Image>().sprite = papa;
                break;

            case "rábano":
                vegetalUI = Instantiate(prefabUIVegetal, _rabanosTransform.position, Quaternion.identity, _rabanosTransform);
                vegetalUI.GetComponent<Image>().sprite = rabano;
                break;

            case "nabo":
                vegetalUI = Instantiate(prefabUIVegetal, _nabosTransform.position, Quaternion.identity, _nabosTransform);
                vegetalUI.GetComponent<Image>().sprite = nabo;
                break;
        }
    }

    private void VaciarBandeja()
    {
        bandejaVegetales["papa"] = 0;
        bandejaVegetales["rábano"] = 0;
        bandejaVegetales["nabo"] = 0;
        VaciarBandejaUI();
    }
    private void VaciarBandejaUI()
    {
        foreach (Transform child in _papasTransform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in _rabanosTransform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in _nabosTransform)
        {
            Destroy(child.gameObject);
        }
    }


    private void RestarVegetales()
    {
        if (bandejaVegetales.SequenceEqual(NpcManager.instance.PedidoBandejaVegetalesActiva))
        {
            inventorySO.Dinero += bandejaVegetales["papa"] * 20 + bandejaVegetales["rábano"] * 10 + bandejaVegetales["nabo"] * 5;
            inventorySO.NumeroPapas -= bandejaVegetales["papa"];
            inventorySO.NumeroRabanos -= bandejaVegetales["rábano"];
            inventorySO.NumeroNabos -= bandejaVegetales["nabo"];
            _Campana.PlayFeedbacks();
            _RecibirDinero.GetFeedbackOfType<MMF_FloatingText>().Value = "+" + (bandejaVegetales["papa"] * 20 + bandejaVegetales["rábano"] * 10 + bandejaVegetales["nabo"] * 5).ToString() + "$";
            _RecibirDinero.PlayFeedbacks();
            _Correct.PlayFeedbacks();
            NpcManager.instance.SiguienteNPC();

        }
        else
        {
            _Error.PlayFeedbacks();
        }
        ActualizarInventario();
        VaciarBandeja();
    }
}