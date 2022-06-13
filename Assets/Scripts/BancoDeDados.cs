using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BancoDeDados : MonoBehaviour
{
    // public static int mortes;
    public static bool Salvar;
       private GameObject[] Datas;

void Awake (){
      Datas = GameObject.FindGameObjectsWithTag ("DATA");
      if (Datas.Length >= 2) {
         Destroy(Datas[0]);
      }
      DontDestroyOnLoad (transform.gameObject);
   }

    // Start is called before the first frame update
    void Start()
    {
        Salvar = false;
        NaveJogador.mortes = PlayerPrefs.GetInt("savMortes");
    }

    // Update is called once per frame
    void Update()
    {
        if(Salvar == true){

            PlayerPrefs.SetInt("savMortes", NaveJogador.mortes );
            Salvar= false;
        }
    }
}
