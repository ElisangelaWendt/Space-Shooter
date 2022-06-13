using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class EndGame : MonoBehaviour
{
    public Button BotaoJogar, BotaoMenu;
    public string nomeCenaJogo = "Level1", menu = "Menu";
    private string nomeDaCena;

    // Start is called before the first frame update
    void Start()
    {
        BotaoJogar.onClick = new Button.ButtonClickedEvent();
        BotaoMenu.onClick = new Button.ButtonClickedEvent();
        BotaoJogar.onClick.AddListener(() => Jogar());
        BotaoMenu.onClick.AddListener(() => Menu());
    }

    // Update is called once per frame
    void Update()
    {
    }

        private void Jogar() {
        SceneManager.LoadScene(nomeCenaJogo);
    }
    private void Menu() {
        SceneManager.LoadScene(menu);
        
    }

}
