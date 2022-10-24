using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float lerpSpeed = 1.0f;

    private Vector3 _offset;

    private Vector3 _targetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!target) return;
        _offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!target) return;
        _targetPos = new Vector3(0, target.position.y + _offset.y,-10);
        transform.position = Vector3.Lerp(transform.position, _targetPos, lerpSpeed * Time.deltaTime);
    }
}
