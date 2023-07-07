using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject pausePanel;
    public static bool isPaused;

    public int sceneRandomizer;

    private void Start()
    {
        pausePanel = GameObject.Find("PausePanel");
        Reanudar();
        isPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
        {
            if (isPaused == false)
            {
                Pausa();
                isPaused = true;
            }
            else
            {
                Reanudar();
                isPaused = false;
            }
        }
    }

    public void Pausa()
    {
        Time.timeScale = 0;
        Debug.Log("Pausa");
        pausePanel.SetActive(true);
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        Debug.Log("Reanudar");
        pausePanel.SetActive(false);
    }

    public void CambioEscena()
    {
        sceneRandomizer = Random.Range(1, 12);
        Debug.Log(sceneRandomizer);
        if (sceneRandomizer >= 1 && sceneRandomizer < 5)
        {
            SceneManager.LoadScene("Cueva");
            sceneRandomizer = 0;
        }
        else if (sceneRandomizer >= 5 && sceneRandomizer < 9)
        {
            SceneManager.LoadScene("Nivel 1");
            sceneRandomizer = 0;
        }
        else if (sceneRandomizer >= 9 && sceneRandomizer < 13)
        {
            SceneManager.LoadScene("Raíces");
            sceneRandomizer = 0;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("CasaDiseñoLvl");
    }

    public void Store()
    {
        SceneManager.LoadScene("Tienda");
    }
}
