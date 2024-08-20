using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pause : MonoBehaviour
{
    public UnityEvent OnPause;
    public UnityEvent OnUnPause;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 0)
            {
                //Despause
                Time.timeScale = 1;
                OnUnPause.Invoke();
                //Pause
                Time.timeScale = 0;
                OnPause.Invoke();
            }
        }
    }
}
