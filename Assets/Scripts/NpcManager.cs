using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcManager : MonoBehaviour
{
    public Dictionary<string, int> PedidoBandejaVegetalesActiva = new Dictionary<string, int>();
    [SerializeField] private TextMeshProUGUI textoPedido;
    [Header("NPC's")]
    [SerializeField] private GameObject npcClaseMedia;
    [SerializeField] private GameObject npcClaseAlta;
    [SerializeField] private GameObject npcClaseBaja;
    public static NpcManager instance;
    public GameObject npcActual;

    int _maxNPC = 5;
    int _NPCCount = 1;

    private void Awake()
    {
        instance = this;
        _VaciarBandeja();
    }
    void Start()
    {
        CrearNPC();

    }

    // Update is called once per frame
    void Update()
    {
        textoPedido.text = "\nNabos: " + PedidoBandejaVegetalesActiva["nabo"] + "\nRábanos: " + PedidoBandejaVegetalesActiva["rábano"] + "\nPapas: " + PedidoBandejaVegetalesActiva["papa"];
    }
    public void SiguienteNPC()
    {
        if (_NPCCount < _maxNPC)
        {
            _NPCCount++;
            npcActual.GetComponent<NPCClaseMedia>().OnNext.Invoke();
            _VaciarBandeja();
            CrearNPC();
        }
        else
        {
            LevelManager.lm.SumLevel();
            return;
        }

    }
    private void _VaciarBandeja()
    {
        PedidoBandejaVegetalesActiva["papa"] = 0;
        PedidoBandejaVegetalesActiva["rábano"] = 0;
        PedidoBandejaVegetalesActiva["nabo"] = 0;
    }
    private void CrearNPC()
    {
        float randomValue = Random.value;
        if (randomValue <= 0.5f)
        {
            Instantiate(npcClaseBaja, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (randomValue > 0.5f && randomValue <= 0.8f)
        {
            Instantiate(npcClaseMedia, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(npcClaseAlta, new Vector3(0, 0, 0), Quaternion.identity);
        }

    }
}
