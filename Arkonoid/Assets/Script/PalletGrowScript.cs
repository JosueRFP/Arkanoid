using UnityEngine;

public class PalletGrowScript : MonoBehaviour
{
    public float tamanhoAtual;
    public float tamanhoMax;
    public float high = 1.7f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Grow(other);
        }
    }
    void Grow (Collider2D pallet)
    {
        if (tamanhoAtual >= tamanhoMax) 
        {
            return;
        }
        pallet.transform.localScale *= high;
       
    }
}
