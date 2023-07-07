using UnityEngine.Events;
using UnityEngine;

namespace GrimoireScripts
{
    public class PuertaNextLevel : MonoBehaviour
    {
        [SerializeField] private UnityEvent OnPlayerEnter;
        private int numPlayers = 0;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<BetaMove>().OnDeactivate();
                if (numPlayers == 0)
                {
                    other.GetComponent<Inventory>().sumarVegetal(3);
                    if (GameManager.gm.DeadPlayers == 1)
                        OnPlayerEnter.Invoke();
                }
                else
                    other.GetComponent<Inventory>().sumarVegetal(1);
                numPlayers++;
                if (numPlayers == 2)
                    OnPlayerEnter.Invoke();
            }
        }
        public void nextLevel()
        {
            LevelManager.lm.SumLevel();
        }
    }
}
