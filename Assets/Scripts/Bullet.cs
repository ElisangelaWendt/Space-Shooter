using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

public float speed = 20f;
public Rigidbody2D rb;
public static int dano = 2;

    // Start is called before the first frame update
    void Start()
    {
      if(NaveJogador.mortes >= 20){
        dano = 4;
      }
        rb.velocity = transform.right * speed;
        Destroy(this.gameObject, 2);
    }
    void OnCollisionEnter2D(Collision2D col){
      if(NaveJogador.mortes >= 20){
        dano = 4;
      }
     if(col.gameObject.layer == 7){
        col.gameObject.GetComponent<Inimigo>().TakeDamage(dano);
        Destroy(gameObject);
      }
      if(col.gameObject.layer == 9  || col.gameObject.layer == 11){
        Destroy(gameObject);
      }
      if(col.gameObject.layer == 10 ){
         col.gameObject.GetComponent<Boss>().TakeDamage(dano);
        Destroy(gameObject);
      }
    }

}
