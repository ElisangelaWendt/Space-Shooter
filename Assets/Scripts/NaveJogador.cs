using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class NaveJogador : MonoBehaviour
{

    public Rigidbody2D rb;
    public float velocidadeMovimento;
    public int life = 0, maxLife = 0, total = 0;
    public LifeBar lifeBar;
    public AudioClip clip;
    public string nomeCenaJogo = "Level2", nomeCena = "Menu";
    public static int mortes;
    public Text texto;
    public Image imagem;
    public static bool morto = false;


    // Start is called before the first frame update
    void Start()
    {
     lifeBar.SetMaxLife(life);
     if(mortes >= 50){
            Ativar(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(mortes == 50){
            Ativar(true);
        }else{
        texto.text = "Inimigos mortos: " + mortes.ToString();
        }


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidadeX = (horizontal * this.velocidadeMovimento);
        float velocidadeY = (vertical * this.velocidadeMovimento);

        this.rb.velocity = new Vector2(velocidadeX, velocidadeY);
    }

    private void Ativar(bool ativarOP){
        texto.gameObject.SetActive(!ativarOP);
        imagem.gameObject.SetActive(ativarOP);
    }

    public void TakeDamage(int damage){
       life -= damage;
       if(life > maxLife)
{
    life = maxLife;
}
       lifeBar.SetLife(life);

       if(life <= 0){
        morto = true;
          AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 1F);
          Destroy(gameObject);
        SceneManager.LoadScene(nomeCena);
       }
    }

    public void NextLevel(int quantidade){
        if(total == 5){
            //passa de fase
        SceneManager.LoadScene(nomeCenaJogo);
        }else{
            total += quantidade;
        }
    }

}
