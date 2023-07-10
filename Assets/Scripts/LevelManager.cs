using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //create a singleton
    public static LevelManager lm;
    public static int NumOfLevel = 1;
    [SerializeField] public LevelSelector levelSelector;

    [Header("Debug")]
    [SerializeField] private bool activado = false;
    [SerializeField] private int NumOfLevelActual = 1;
    [SerializeField] private InventoryScriptableObject inventoryScriptableObjectP1;
    [SerializeField] private InventoryScriptableObject inventoryScriptableObjectP2;

    void Awake()
    {
        if (lm == null)
        {
            lm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {

        UIManager.uim.SetLapsCount(NumOfLevel);

    }
    public void SumLevel()
    {
        if (inventoryScriptableObjectP1.Dinero >= 1000)
        {
            SceneManager.LoadScene("WinP1");
        }
        else if (inventoryScriptableObjectP2.Dinero >= 1000)
        {
            SceneManager.LoadScene("WinP2");
        }
        if (GameManager.gm.gameState != GameState.Store)
        {
            NumOfLevel++;
        }
        if (NumOfLevel > 3)
        {
            NumOfLevel = 1;
            levelSelector.LoadTienda();
        }
        else
        {
            levelSelector.LoadLevel();
        }


    }

}
