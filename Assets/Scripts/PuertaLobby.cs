
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace GrimoireScripts
{
    public class PuertaLobby : MonoBehaviour
    {
        public int numPlayersIn;
        [SerializeField] private Animator _iconPlayer1, _iconPlayer2;
        [SerializeField] private TextMeshProUGUI _textTimer;
        private float timeToStart = 3f;
        private bool canStart = false;
        [Header("Events")]
        public UnityEvent StartEvent;

        // Update is called once per frame
        void Update()
        {
            if (canStart)
            {
                StartScene();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            //if player enters
            if (other.CompareTag("Player"))
            {
                numPlayersIn++;
                if (other.GetComponent<BetaMove>().isPlayer1)
                {
                    JoinPlayer(_iconPlayer1);
                }
                else
                {
                    JoinPlayer(_iconPlayer2);
                }
                if (numPlayersIn == 2)
                {
                    canStart = true;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            //if player exits
            if (other.CompareTag("Player"))
            {
                numPlayersIn--;
                if (other.GetComponent<BetaMove>().isPlayer1)
                {
                    LeavePlayer(_iconPlayer1);
                }
                else
                {
                    LeavePlayer(_iconPlayer2);
                }
                if (numPlayersIn < 2)
                {
                    _textTimer.gameObject.SetActive(false);
                    canStart = false;
                    timeToStart = 3f;
                }
            }
        }
        private void StartScene()
        {
            _textTimer.gameObject.SetActive(true);
            _textTimer.text = Mathf.RoundToInt(timeToStart).ToString();

            if (timeToStart <= 0)
            {
                StartEvent.Invoke();
            }
            else
            {
                timeToStart -= Time.deltaTime;
            }
        }
        private void JoinPlayer(Animator player)
        {
            player.SetBool("active", true);
            player.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        private void LeavePlayer(Animator player)
        {
            player.SetBool("active", false);
            player.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        }
    }

}
