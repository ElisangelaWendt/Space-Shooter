using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

public Transform Ponto;
public GameObject[] enemy;
   private float cronometro;
   public float tempoPorSpawn;

	void Start () {
        Instantiate(enemy[Random.Range (0,enemy.Length)], Ponto.position, Ponto.rotation);
    }

    void Update () {
      cronometro += Time.deltaTime;
      if (cronometro >= tempoPorSpawn) {

         Instantiate(enemy[Random.Range (0,enemy.Length)], Ponto.position, Ponto.rotation);
         cronometro = 0;
      }
   }

}