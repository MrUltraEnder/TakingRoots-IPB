using UnityEngine;

namespace GrimoireScripts
{
    public class Inventory : MonoBehaviour
    {

        private BetaMove playermov;
        [SerializeField] public InventoryScriptableObject inventario;

        [SerializeField] SpriteRenderer VegetalSeleccionadoSprite;
        [SerializeField] Sprite NaboSprite;
        [SerializeField] Sprite RabanoSprite;
        [SerializeField] Sprite PapaSprite;

        public Sprite[] spritesVegetales;

        [SerializeField] private int _vegetalSeleccionado => inventario.VegetalSeleccionado;

        private void Start()
        {
            spritesVegetales = new Sprite[3];
            spritesVegetales[0] = NaboSprite;
            spritesVegetales[1] = RabanoSprite;
            spritesVegetales[2] = PapaSprite;
            playermov = GetComponent<BetaMove>();
            if (playermov.isPlayer1)
            {
                inventario.VegetalSeleccionado = UIManager.posP1 + 1;
                // Debug.Log("Vegetal seleccionado: " + VegetalSeleccionado + 1);
            }
            else
            {
                inventario.VegetalSeleccionado = UIManager.posP2 + 1;
                // Debug.Log("Vegetal seleccionado: " + VegetalSeleccionado + 1);
            }

            vegetalSprite();
        }
        private void Update()
        {
            if (playermov.isPlayer1)
            {
                UIManager.uim._dineroPlayer1UI(inventario.Dinero);
            }
            else
            {
                UIManager.uim._dineroPlayer2UI(inventario.Dinero);
            }
        }

        public void vegetalSprite()
        {
            switch (inventario.VegetalSeleccionado)
            {
                case 1:
                    VegetalSeleccionadoSprite.sprite = NaboSprite;
                    break;
                case 2:
                    VegetalSeleccionadoSprite.sprite = RabanoSprite;
                    break;
                case 3:
                    VegetalSeleccionadoSprite.sprite = PapaSprite;
                    break;
                default:
                    Debug.LogError("Invalid selected vegetable index");
                    break;
            }
        }

        public void sumarVegetal(int Posicion)
        {
            switch (inventario.VegetalSeleccionado)
            {
                case 1:
                    inventario.NumeroNabos += Posicion;
                    break;
                case 2:
                    inventario.NumeroRabanos += Posicion;
                    break;
                case 3:
                    inventario.NumeroPapas += Posicion;
                    break;
                default:
                    Debug.LogError("Invalid selected vegetable index");
                    break;
            }
        }
        public void addMoney(int money)
        {
            inventario.Dinero += money;
        }
    }
}