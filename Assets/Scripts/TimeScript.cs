using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private bool isPaused;
    public TMP_Text pausedText;
    public TMP_Text loadingText;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
                
            }
        }
        if(Input.GetKeyDown("space"))
        {
            //START COROUTINE HERE
            StartCoroutine(loading());
            //END OF CODE
        }
    }

    void PauseGame()
    {
       Time.timeScale=0f;
        //WRITE CODE HERE
        isPaused = true;

        //END OF CODE
        pausedText.enabled = true;
        pausedText.gameObject.SetActive(true);
    }
    
    void ResumeGame()
    {
        //WRITE CODE HERE
        Time.timeScale=1f;
        isPaused = false;

        //END OF CODE
        pausedText.gameObject.SetActive(false);
        pausedText.enabled = false;
        
    }

    //CREATE COROUTINE HERE
    public IEnumerator loading()
    {
        loadingText.text = "This text will go away in 3 seconds";
        yield return new WaitForSeconds(3f);
        loadingText.text = "EndOfCoroutine";
    }
    //END OF CODE
}
