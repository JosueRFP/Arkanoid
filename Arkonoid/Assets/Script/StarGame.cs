using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarGame : MonoBehaviour
{
    public Text countdownText;
    public GameObject player;
    public GameObject bola;
    public GameObject spawn;
    public GameObject[] resources;
    private bool gamePaused;
   
    void Start()
    {
       
        /*
        for (int i = 0; i < resources.Length; i++)
        {
            resources[i].SetActive(false);
        }
        */
        player.SetActive(false);
        bola.SetActive(false);
        spawn.SetActive(false);

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

        /*
          for (int i = 0; i < resources.Length; i++)
          {
              resources[i].SetActive(true);
          }
          */
        countdownText.gameObject.SetActive(false);
        player.SetActive(true);
        bola.SetActive(true);
        spawn.SetActive(true);

        gamePaused = false;
    }

    void Update()
    {
     

    }
}