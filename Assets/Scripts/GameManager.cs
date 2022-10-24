using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject platform1;  
    [SerializeField] private GameObject platform2;
    [SerializeField] private GameObject platform3;
    public float maxHeight;
    public bool isPaused;
    public bool isEnded;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
        }
        if (!platform1)
        {
            platform1 =  Instantiate(platform, transform);
            platform1.transform.position = new Vector3(0, player.transform.position.y + Random.Range(5.5f, 7.0f), 0);
            platform1.GetComponent<PlatformController>().speed = Random.Range(3f, 5.0f);
            platform1.transform.localScale += new Vector3(Random.Range(-1f, 1f), 0, 0);
        } 
        else if (!platform2)
        {
            platform2 = Instantiate(platform, transform);
            platform2.transform.position = new Vector3(0, player.transform.position.y + Random.Range(5.5f, 7.0f), 0);
            platform2.GetComponent<PlatformController>().speed = Random.Range(3f, 5.0f);
            platform2.transform.localScale += new Vector3(Random.Range(-1f, 1f), 0, 0);
        } 
        else if  (!platform3)
        {
            platform3 = Instantiate(platform, transform);
            platform3.transform.position = new Vector3(0, player.transform.position.y + Random.Range(5.5f, 7.0f), 0);
            platform3.GetComponent<PlatformController>().speed = Random.Range(3f, 5.0f);
            platform3.transform.localScale += new Vector3(Random.Range(-1f, 1f), 0, 0);
        }

        var height = player.transform.position.y + 3;
        if (height > maxHeight)
        {
            maxHeight = height;
        }
        score.text = $"Height: {(int)maxHeight:0000}";
    }
    
}
