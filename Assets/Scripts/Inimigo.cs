using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public Rigidbody2D rb;
    public float velocidadeMinima;
    public float velocidadeMaxima;
    public int life;
    public AudioClip clip, hit;

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
          AudioSource.PlayClipAtPoint(hit, Camera.main.transform.position, 1F);
        Destroy(gameObject);
      }
      if(col.gameObject.layer == 8) { //camera
          Destroy(gameObject);
      }
    }

    


}
