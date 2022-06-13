using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBooster : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidadeMinima;
    public float velocidadeMaxima;
    private float velocidadeY;
    public AudioClip clip;

    void Start()
    {
        this.velocidadeY = Random.Range(this.velocidadeMinima, this.velocidadeMaxima);
    }

    void Update()
    {
        this.rb.velocity = new Vector2(-this.velocidadeY, 0 );
    }


    void OnCollisionEnter2D(Collision2D col){
     if(col.gameObject.layer == 6){ //player
        col.gameObject.GetComponent<NaveJogador>().TakeDamage(-2);
          AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 1F);
        Destroy(gameObject);
      }
      if(col.gameObject.layer == 8) { //camera
          Destroy(gameObject);
      }
    }
}
