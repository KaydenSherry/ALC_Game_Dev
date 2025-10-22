using UnityEngine;

public class Coin : MonoBehaviour
{

    public int scoreToGive;
    private float startYPos;
    public float bobHeight;
    public float bobSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //increase the score
            collision.GetComponent<PlayerController2D>().AddScore(scoreToGive);
            //Obliterate the coin from existence
            Destroy(gameObject);
        }
    }

    void Start()
    {
        startYPos = transform.position.y;
    }
    
    void Update()
    {
        float newY = startYPos + (Mathf.Sin(Time.time * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, 0);
    }

}
