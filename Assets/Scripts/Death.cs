using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.gameObject.GetComponent<PlayerController>().Death();
            gm.isEnded = true;
        }
    }
}
