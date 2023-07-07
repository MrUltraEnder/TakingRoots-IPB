using System.Collections;
using UnityEngine;
using UnityEngine.Events;
namespace GrimoireScripts
{

    public class BetaMove : MonoBehaviour
    {
        [Header("Events")]
        public UnityEvent OnJumpEvent;
        public UnityEvent OnDashEvent;
        public UnityEvent OnLandEvent;
        public UnityEvent OnAttackEvent;
        public UnityEvent OnStunedEvent;
        public UnityEvent OnDeactivateEvent;
        public UnityEvent OnWalkEventStart;
        public UnityEvent OnWalkEventEnd;
        [Space]

        [Header("Physics")]
        private Rigidbody2D rb;
        private Collider2D myCollider;



        [Header("Shoot")]
        [SerializeField] private Transform firePoint;
        [SerializeField] public GameObject _vegetalFake;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private float bulletForce = 20f;
        [SerializeField] private bool canAttack;
        private float timerForAttack = .2f;
        private float maxTimeForAttack = .2f;
        public bool canGrab = false;

        [Header("Stun")]
        [SerializeField] private bool isStuned;
        [SerializeField] private int stuntTime;
        private float _velocityBeforeStun;



        [Header("Others")]
        public Animator anim;
        public bool agarrar = true;
        public GameObject vegetalpos;
        private PlayerInput myInputs;
        public bool isPlayer1;
        private Inventory operations;
        private IPlayerController _player;
        private Inventory _inventory;
        [SerializeField] private ParticleSystem _particleMovement;
        [SerializeField] private GameObject _DashBoom;


        [Header("Muerte")]
        private float maxTimeForDead = 2f;
        private float timerForDead;
        private bool onDeadCollider;
        private bool isAlive = true;
        private PlayerController _playerController;


        private void Awake()
        {
            _player = GetComponentInParent<IPlayerController>();
            _playerController = GetComponentInParent<PlayerController>();
            _inventory = GetComponent<Inventory>();
            myInputs = GetComponent<PlayerInput>();
            rb = GetComponent<Rigidbody2D>();
            myCollider = GetComponent<Collider2D>();
            operations = GetComponent<Inventory>();
        }
        void Start()
        {
            _velocityBeforeStun = _playerController.PlayerStats.MaxSpeed;
            timerForDead = maxTimeForDead;
            timerForAttack = maxTimeForAttack;
            _playerController.Attacked += Attack;

        }

        private void Update()
        {
            if (GameManager.gm.gameState == GameState.Pause)
                return;
            DeadCounter();
            animationsSet();
            if (!onDeadCollider)
                OnWalk();
            Attack();
            AttackCooldown();
            Flip();

        }

        void FixedUpdate()
        {

        }

        #region colisiones
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("vegetal"))
            {
                if (!agarrar)
                {
                    if (canGrab)
                    {
                        _inventory.inventario.VegetalSeleccionado = collision.gameObject.GetComponent<VegetalBalaScript1>().tipoVegetal;
                        _inventory.vegetalSprite();
                        Destroy(collision.gameObject);
                        agarrar = true;
                        canGrab = false;
                        _vegetalFake.SetActive(true);
                    }
                }
                else
                {
                    GetStuned();
                }
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            onDeadCollider = collision.gameObject.CompareTag("Killer") ? true : onDeadCollider;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            onDeadCollider = other.gameObject.CompareTag("Killer") ? false : onDeadCollider;

        }
        #endregion
        #region flip
        public void Flip()
        {
            if (_player.Input.x != 0) transform.localScale = new Vector3(_player.Input.x > 0 ? 1 : -1, 1, 1);
        }
        #endregion
        #region dash


        #endregion
        #region stun
        public void Attack()
        {
            if (myInputs.FrameInput.AttackDown)
                if (canAttack && agarrar)
                {
                    Debug.Log("Shoot");
                    Shoot();
                    canAttack = false;
                }
        }
        public void Shoot()
        {
            agarrar = false;
            Invoke("agarrado", .2f);
            OnAttackEvent.Invoke();
            GameObject VegetalLanzado = Instantiate(bulletPrefab, vegetalpos.transform.position, Quaternion.identity);
            //change spriterenderer
            VegetalLanzado.GetComponent<SpriteRenderer>().sprite = _vegetalFake.GetComponent<SpriteRenderer>().sprite;
            VegetalLanzado.GetComponent<VegetalBalaScript1>().tipoVegetal = _inventory.inventario.VegetalSeleccionado;
            _vegetalFake.SetActive(false);
            Vector2 direction = new Vector2(firePoint.transform.position.x - vegetalpos.transform.position.x, firePoint.transform.position.y - vegetalpos.transform.position.y);
            //Debug.Log(direction.x + " : " + direction.y);
            VegetalLanzado.GetComponent<Rigidbody2D>().AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }
        private void agarrado()
        {
            canGrab = true;
        }
        public void GetStuned()
        {
            if (!isStuned)
            {
                StartCoroutine(Stunt());
            }
        }
        private IEnumerator Stunt()
        {
            Debug.Log("Stunt");
            isStuned = true;
            OnStunedEvent.Invoke();
            _playerController.ChangeVelocity(_velocityBeforeStun / 4);
            yield return new WaitForSeconds(stuntTime);
            _playerController.ChangeVelocity(_velocityBeforeStun);
            isStuned = false;
            Debug.Log("StuntEnd");
        }
        private void AttackCooldown()
        {
            if (!canAttack)
            {
                timerForAttack -= Time.deltaTime;
                if (timerForAttack <= 0)
                {
                    canAttack = true;
                    timerForAttack = maxTimeForAttack;
                }
            }
        }
        #endregion


        public void animationsSet()
        {
            if (_player == null) return;
            if (Mathf.Abs(_playerController.Velocity.magnitude) > 0f)
                _particleMovement.Play();
            else
                _particleMovement.Stop();
            anim.SetFloat("VerticalSpeed", rb.velocity.y);
            anim.SetBool("Grounded", _playerController.Grounded);
            anim.SetBool("Agarrar", agarrar);
            anim.SetBool("Wall", _playerController.WallSliding);
            anim.SetFloat("Velocidad", Mathf.Abs(_playerController.Velocity.x));


        }
        public void OnWalk()
        {
            if (Mathf.Abs(_playerController.Velocity.x) > 0.1f)
            {
                OnWalkEventStart.Invoke();
            }
            else
            {
                OnWalkEventEnd.Invoke();
            }
        }

        public void OnDash()
        {
            GameObject dashBoom = Instantiate(_DashBoom, transform.position, Quaternion.identity);
            Destroy(dashBoom, 1f);
            anim.SetTrigger("Dashing");
            OnDashEvent.Invoke();

        }
        private void DeadCounter()
        {

            if (onDeadCollider)
            {
                timerForDead -= Time.deltaTime;
                if (timerForDead <= 0 && isAlive)
                {
                    Debug.Log("Dead" + gameObject.name);
                    GameManager.gm.OnDeadPlayer();
                    isAlive = false;
                    gameObject.SetActive(false);
                }
            }
            else
            {
                timerForDead = maxTimeForDead;
            }
        }
        public void OnDeactivate()
        {
            _playerController.ChangeVelocity(0);
            OnDeactivateEvent.Invoke();
        }
        public void SaltarEvent()
        {
            if (!onDeadCollider)
                OnJumpEvent.Invoke();
        }
    }

}