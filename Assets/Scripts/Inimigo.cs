using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class Inimigo : MonoBehaviour
{

    public Rigidbody2D rb;
    public float velocidadeMinima;
    public float velocidadeMaxima;
    public int life;
    public AudioClip clip, hit;
  public GameObject explosion;
  public Transform Ponto;

    private float velocidadeY;

    // Start is called before the first frame update
    void Start()
    {
        this.velocidadeY = Random.Range(this.velocidadeMinima, this.velocidadeMaxima);
    }

 public void TakeDamage(int damage){
        life -= damage;

        if(life <= 0){
          NaveJogador.mortes += 1;
          Instantiate(explosion, Ponto.position, Ponto.rotation);
          AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 1F);
          Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.rb.velocity = new Vector2(-this.velocidadeY, 0 );
    }


    void OnCollisionEnter2D(Collision2D col){
     if(col.gameObject.layer == 6){ //player
        col.gameObject.GetComponent<NaveJogador>().TakeDamage(2);
          Instantiate(explosion, Ponto.position, Ponto.rotation);
          AudioSource.PlayClipAtPoint(hit, Camera.main.transform.position, 1F);
          Destroy(gameObject);
      }
      if(col.gameObject.layer == 8) { //camera
          Destroy(gameObject);
      }
    }

    


}
