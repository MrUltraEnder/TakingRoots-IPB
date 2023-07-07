using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float MaxSpeedForLevel;
    [SerializeField] private float AccelerationRate;
    [SerializeField] private bool activado = true;

    void Start()
    {

    }

    void Update()
    {
        //translate camera moving to right along the time
        if (GameManager.gm.gameState == GameState.Game)
        {
            if (activado)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                Acceleration();
            }

        }
    }
    public void Acceleration()
    {
        if (speed < MaxSpeedForLevel)
        {
            //acelerar el movimiento cada 2 segundos
            speed += AccelerationRate * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fin"))
        {
            activado = false;
        }

    }
}
