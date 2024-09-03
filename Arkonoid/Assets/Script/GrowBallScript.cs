using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBallScript : MonoBehaviour
{
    public float bolaAtual;
    public float bolaFinal;
    public int multiplier = 3;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(0f, -1f) * Time.deltaTime * speed   );
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(bolaAtual >= bolaFinal)
        {
            return;
        }
        if (other.CompareTag("Player"))
        {           
            Pickup(other);
        }
        
    }
    //tudo que est� em verde � o tipo por exemplo os Collider2D.
    void Pickup(Collider2D bola)
    {
        Debug.Log("Pao de cada dia!");

        //GetComponent<Bola>();
        bola.transform.localScale *= multiplier;

        Destroy(gameObject);
      
    }


}// fonte: https://www.youtube.com/watch?v=CLSiRf_OrBk

