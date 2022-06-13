using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{

public float speed = 20f;
public Rigidbody2D rb;
public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        this.rb.velocity = new Vector2(-this.speed, 0 );

        Destroy(this.gameObject, 2);
    }
    void OnCollisionEnter2D(Collision2D col){
     if(col.gameObject.layer == 6){
        col.gameObject.GetComponent<NaveJogador>().TakeDamage(2);
          AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 1F);
        Destroy(gameObject);
      }
      if(col.gameObject.layer == 9  || col.gameObject.layer == 11 || col.gameObject.layer == 7 || col.gameObject.layer ==8 ){
        Destroy(gameObject);
      }
    }

}
