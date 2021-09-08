using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    public TMP_Text scoreText;
    private int currentNum;
    public int score = 0;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        currentNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // currentNum +=1;
        // print(currentNum);
        //INCREMENT AND PRINT CURRENTNUM HERE 

        //Uncomment the code below and complete 
        // the if statement to check if Mouse0 is clicked 
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
