using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "my score:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "danger")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (collision.gameObject.tag == "coin")
        {
            score++;
            scoreText.text = "my score:" + score;
            Destroy(collision.gameObject);
        }
    }

}
