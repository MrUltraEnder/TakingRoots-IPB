using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

//create menu

public class LevelSelector : MonoBehaviour
{
    public List<string> scenesToLoad;
    [SerializeField] private ListadeEscenasScriptableObject listaDeEscenas;

    private void Start()
    {
        scenesToLoad = listaDeEscenas.scenes;
    }
    // Carga un nivel aleatorio
    public void LoadLevel()
    {

        int sceneIndex;
        do
        {
            sceneIndex = Random.Range(0, scenesToLoad.Count);
        } while (SceneManager.GetActiveScene().name == scenesToLoad[sceneIndex]);

        SceneManager.LoadScene(scenesToLoad[sceneIndex]);
    }
    public void LoadTienda()
    {
        SceneManager.LoadScene("Tienda");
    }
}
