using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerUI1 : MonoBehaviour
{
    [SerializeField]
    private float tiempoMax = 5;
    public float tiempo = 5;
    private Slider timerSlider;
    void Start()
    {
        timerSlider = GetComponent<Slider>();
        timerSlider.maxValue = tiempoMax;
        tiempo = tiempoMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            timerSlider.value = tiempo;
        }

    }
}
