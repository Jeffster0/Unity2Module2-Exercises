using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    public TMP_Text updateText;
    public TMP_Text fixedUpdateText;
    //Declare and intialize updateCounter and fixedUpdateCounter here
    public float updateCounter;
    public float fixedUpdateCounter;
    //Declare mr here
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        //Set mr to get MeshRenderer component here
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update(){
        //disable MeshRenderer component below
        mr.enabled = false;
        //increment updateCounter by 1 below
        updateCounter += 1;
        //END OF CODE
        
        //Uncomment line below when update function is completed
        updateText.text = "Update Counter: " + updateCounter.ToString();
        
    }
    
    //Create FixedUpdate function below
    void FixedUpdate()
    {
        //increment fixedUpdateCounter by 1 and update fixedUpdateText below
        fixedUpdateCounter += 1;
        fixedUpdateText.text = "fixedUpdateCounter:" + fixedUpdateCounter.ToString();
        
        //END OF CODE
    }
}
