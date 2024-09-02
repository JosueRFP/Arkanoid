using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBallScript : MonoBehaviour
{
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
        if (other.CompareTag("Bola"))
        {
            Pickup(other);
        }
    }
    //tudo que está em verde é o tipo por exemplo os Collider2D.
    void Pickup(Collider2D bola)
    {
        Debug.Log("Pao de cada dia!");

        bola.transform.localScale *= multiplier;

        Destroy(gameObject);
    }


}// fonte: https://www.youtube.com/watch?v=CLSiRf_OrBk

