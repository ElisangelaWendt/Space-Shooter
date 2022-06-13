using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class Boss : MonoBehaviour
{
//Declaramos a variável que vai controlar a velocidade da câmera
    public float velocidade = 5.0f;

    //Acessa o objeto que que a câmera precisa seguir
    public Transform target;

    //Qual o distânciamento dos eixos entre a câmera e o player
    public Vector3 offset = Vector3.up;

    public Rigidbody2D rb;
    public static int life;
    public AudioClip clip;
    public string nomeCenaJogo = "EndGame";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (target!=null){ //verifica se o rigidbody selecionado para ser seguido existe
         transform.position = Vector3.Lerp(transform.position, target.position + offset, velocidade * Time.deltaTime);
       }
    }

    public void TakeDamage(int damage){
        life -= damage;

        if(life <= 0){
          AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 1F);
          Destroy(gameObject);
          SceneManager.LoadScene(nomeCenaJogo);
        }
    }
}
