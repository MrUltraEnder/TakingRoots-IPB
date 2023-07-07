using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FondoInfinito_UI_MenuInicial : MonoBehaviour
{
    [SerializeField]
    RawImage ImagenLoca;
    Rect Coso;
    [SerializeField]
    float Velocidad;

    void Start()
    {
        Coso = ImagenLoca.uvRect;
    }

    // Update is called once per frame
    void Update()
    {
        Coso.x += Velocidad*Time.deltaTime;
        ImagenLoca.uvRect = Coso; 

    }
}
