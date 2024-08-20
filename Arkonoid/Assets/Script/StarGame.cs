using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarGame : MonoBehaviour
{
    public Text countdownText; 
    public GameObject player;
    void Start()
    {
     
        player.SetActive(false);

       
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        int countdownTime = 3; 

       
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f); 
            countdownTime--; 
        }

        
        countdownText.text = "Go!";
        yield return new WaitForSeconds(1f);
        countdownText.gameObject.SetActive(false); 
        player.SetActive(true); 
    }
}