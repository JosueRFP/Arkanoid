using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLifeScript : MonoBehaviour
{
    public int actualLife;
    public int lifeMax = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(other.CompareTag("+ vida")) 
            {
                if (actualLife >= lifeMax)
                    return;
            actualLife += 1;
            if(actualLife >= lifeMax)
            {
                actualLife = lifeMax;
                Destroy(gameObject);
            }

            }    
        }
       
    }
}
