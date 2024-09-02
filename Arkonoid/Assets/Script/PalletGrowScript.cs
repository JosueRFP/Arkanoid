using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletGrowScript : MonoBehaviour
{
    public float grow = 1.7f; 

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
        if (other.CompareTag("Bola"))
        {
            Scale(other);
        }
    }
    void Scale(Collider2D pallet)
    {
        pallet.transform.localScale *= grow;
    }
}
