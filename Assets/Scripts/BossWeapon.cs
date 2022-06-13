using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
public Transform Ponto;
public GameObject bullet;
private float cronometro;
public float tempoSpawn;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cronometro += Time.deltaTime;
      if (cronometro >= tempoSpawn) {
        Instantiate(bullet, Ponto.position, Ponto.rotation);
         cronometro = 0;
      }
    }
}
