using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private GameManager _gm;
    private const float Limit = 6.7f;
    public float speed = 2.0f;
    private int _dir = 1;
    private bool _loaded;

    private void Start()
    {
        _gm = GetComponentInParent<GameManager>();
    }

    void Update()
    {
        if (transform.position.x > Limit)
        {
            _dir = -1;
        } else if (transform.position.x < -Limit)
        {
            _dir = 1;
        }

        var move = Vector3.right * (_dir * speed * Time.deltaTime);
        transform.Translate(move);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.position.y > transform.position.y)
        {
            collision.gameObject.transform.SetParent(gameObject.transform,true);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        other.gameObject.transform.parent = null;
    }

    private void OnBecameVisible()
    {
        _loaded = true;
    }

    private void OnBecameInvisible()
    {
        if (_loaded && _gm.maxHeight > transform.position.y + 3)
        {
            Debug.Log($"{_gm.maxHeight}, {transform.position.y-3}");
            Destroy(gameObject);
        }
    }
}
