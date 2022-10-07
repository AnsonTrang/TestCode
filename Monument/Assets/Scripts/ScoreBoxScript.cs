using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoxScript : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col) {
        Destroy(col.gameObject);
        score++;
        scoreText.text = score.ToString();
    }
}
