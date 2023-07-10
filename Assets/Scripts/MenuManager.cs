using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private InventoryScriptableObject inventoryScriptableObjectP1;
    [SerializeField] private InventoryScriptableObject inventoryScriptableObjectP2;
    public UnityEvent OnStartGame;
    bool iniciado;
    // Start is called before the first frame update
    void Start()
    {

        reseter();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            if (iniciado) return;
            OnStartGame.Invoke();
            anim.SetTrigger("Start");
            Invoke("EntrarAlLobby", 2f);
            iniciado = true;
        }

    }

    public void EntrarAlLobby()
    {
        SceneManager.LoadScene("CasaHouse");
    }
    public void reseter()
    {
        inventoryScriptableObjectP1.Dinero = 0;
        inventoryScriptableObjectP2.Dinero = 0;
        inventoryScriptableObjectP1.NumeroPapas = 5;
        inventoryScriptableObjectP2.NumeroPapas = 5;
        inventoryScriptableObjectP1.NumeroRabanos = 5;
        inventoryScriptableObjectP2.NumeroRabanos = 5;
        inventoryScriptableObjectP1.NumeroNabos = 5;
        inventoryScriptableObjectP2.NumeroNabos = 5;
    }
}
