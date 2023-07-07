using System.Collections;
using System.Collections.Generic;
using GrimoireScripts;
using UnityEngine;
using UnityEngine.Events;

public class PartculasCajaSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _particulasPrefab;
    [SerializeField]
    private GameObject _vegetalPrefab;
    [SerializeField]
    private GameObject _coinPrefab;


    public void SpawnVegetal(int tipoVegetal, Sprite vegetalSprite)
    {
        GameObject vegetal = Instantiate(_vegetalPrefab, transform.position, Quaternion.identity);
        vegetal.GetComponent<VegetalBalaScript1>().tipoVegetal = tipoVegetal;
        vegetal.GetComponent<SpriteRenderer>().sprite = vegetalSprite;
    }

    public void SpawnCoins()
    {
        //Darle al jugador dinero extra
        Instantiate(_coinPrefab, transform.position, Quaternion.identity);
    }


    [SerializeField] private UnityEvent _hit;
    private bool Destruida;

    //make the box disappear when it is touched by the player from the top
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.contacts[0].normal.y < 0)
        {
            GameObject player = collision.gameObject;

            if (Destruida == false)
            {
                Destruida = true;
                if (player.GetComponent<BetaMove>().agarrar == false)
                {
                    SpawnVegetal(player.GetComponent<Inventory>().inventario.VegetalSeleccionado, player.GetComponent<Inventory>().spritesVegetales[player.GetComponent<Inventory>().inventario.VegetalSeleccionado - 1]);
                }
                else
                {
                    SpawnCoins();
                }
                _hit.Invoke();
                Destroy(gameObject, .20f);
            }

        }
    }
}
