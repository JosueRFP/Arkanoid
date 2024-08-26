using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarGame : MonoBehaviour
{
    public Text countdownText;
    public GameObject player;
    public GameObject bola;
    private bool gamePaused;

    void Start()
    {
       
        player.SetActive(false);
        bola.SetActive(false);
        gamePaused = true;

        
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
        bola.SetActive(true);
        gamePaused = false;
    }

    void Update()
    {
     

    }
}