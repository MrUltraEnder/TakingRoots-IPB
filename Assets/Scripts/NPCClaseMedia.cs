using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class NPCClaseMedia : MonoBehaviour
{
    public Dictionary<string, int> bandejaVegetales = new Dictionary<string, int>();
    [SerializeField] private TextMeshPro textoPapa;
    [SerializeField] private TextMeshPro textoRabano;
    [SerializeField] private TextMeshPro textoNabo;
    public UnityEvent OnNext;

    [Header("Variables de Vegetales")]
    [SerializeField] private int _minPapa, _maxPapa;
    [SerializeField] private int _minRabano, _maxRabano;
    [SerializeField] private int _minNabo, _maxNabo;


    private Color moreno;

    void Start()
    {
        CrearBandeja();
        _speechBubble();
        NpcManager.instance.PedidoBandejaVegetalesActiva = bandejaVegetales;
        NpcManager.instance.npcActual = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void CrearBandeja()
    {
        bandejaVegetales.Add("papa", Random.Range(_minPapa, _maxPapa));
        bandejaVegetales.Add("rábano", Random.Range(_minRabano, _maxRabano));
        bandejaVegetales.Add("nabo", Random.Range(_minNabo, _maxNabo));
    }
    private void _speechBubble()
    {
        if (bandejaVegetales["papa"] != 0)
        {
            textoPapa.gameObject.SetActive(true);
            textoPapa.text = "x " + bandejaVegetales["papa"].ToString();
        }
        if (bandejaVegetales["rábano"] != 0)
        {
            textoRabano.gameObject.SetActive(true);
            textoRabano.text = "x " + bandejaVegetales["rábano"].ToString();
        }
        if (bandejaVegetales["nabo"] != 0)
        {
            textoNabo.gameObject.SetActive(true);
            textoNabo.text = "x " + bandejaVegetales["nabo"].ToString();
        }


    }
}
