using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbd;
    private Animator _animator;
    private static readonly int Death1 = Animator.StringToHash("Death");

    private void Start()
    {
        _rigidbd = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_rigidbd.velocity == Vector2.zero)
            {
                //_animator.SetBool("Jump", true);
                _rigidbd.AddForce(new Vector2(0, 10.5f), ForceMode2D.Impulse);
                //_animator.SetBool("Jump", false);
            }
            
            
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            Death();
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void Death()
    {
        _animator.SetBool(Death1,true);
    }
}
