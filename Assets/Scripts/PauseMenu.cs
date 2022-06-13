using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class PauseMenu : MonoBehaviour
{

    public string nomeCenaJogo = "Menu";
    public Button BotaoContinuar, BotaoMenu, BotaoSair;
    public static bool isGamePaused = false;

    [SerializeField] GameObject pauseMenu;


    // Start is called before the first frame update
    void Start()
    {
        BotaoContinuar.onClick = new Button.ButtonClickedEvent();
        BotaoSair.onClick = new Button.ButtonClickedEvent();
        BotaoMenu.onClick = new Button.ButtonClickedEvent();
        BotaoContinuar.onClick.AddListener(() => Continuar());
        BotaoMenu.onClick.AddListener(() => Menu());
        BotaoSair.onClick.AddListener(() => Sair());
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isGamePaused){
                ResumeGame();
            }else{
                PauseGame();
            }
        }
    }

    void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void PauseGame(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

private void Continuar() {
ResumeGame();
}

        private void Menu() {
        SceneManager.LoadScene(nomeCenaJogo);
    }

        private void Sair() {
        Application.Quit();
    }

}
