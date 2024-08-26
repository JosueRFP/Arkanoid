using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver: MonoBehaviour
{
    public GameObject gameOverImage;
    public Button botaoRecomecar;
    public Button botaoMenu;

    void Start()
    {
        gameOverImage.SetActive(false); 
        botaoRecomecar.gameObject.SetActive(false);
        botaoMenu.gameObject.SetActive(false);

     
        botaoRecomecar.onClick.AddListener(RecomecarJogo);
        botaoMenu.onClick.AddListener(VoltarAoMenu);
    }

    public void ExibirTelaGameOver()
    {
        gameOverImage.SetActive(true);
        botaoRecomecar.gameObject.SetActive(true);
        botaoMenu.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

  public   void RecomecarJogo()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VoltarAoMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("MenuScene"); 
    }
}
