using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3;

    public float scaleToIncrease = 0.15f;


    public int scoreToGive;


    private ScoreManager scoreManager;

    public GameObject popEffect;

    public Vector3 effectOffset = new Vector3(0, 3, 0);
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        clickToPop -= 1;

        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Instantiate(popEffect, transform.position + effectOffset, transform.rotation);
            Destroy(gameObject);
        }
    }
}
