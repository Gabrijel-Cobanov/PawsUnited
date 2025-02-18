using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuBehavior : MonoBehaviour
{
    [SerializeField] Scene play_scene;

    [SerializeField] GameObject pause_menu;
    [SerializeField] Button continue_button;
    [SerializeField] Button new_game_button;
    [SerializeField] Button settings_button;
    [SerializeField] Button exit_button;
    [SerializeField] Button close_settings_button;
    [SerializeField] Button delete_game_data_button;
    [SerializeField] Button reset_settings_button;

    private bool fullscreen = false;
    private float current_master_volume = 0;
    private float current_SFX_volume = 0;
    private float current_ambience_volume = 0;

    
    void Start() {
        pause_menu.SetActive(false);
        settings_button.onClick.AddListener(TogglePauseActive);
        close_settings_button.onClick.AddListener(TogglePauseActive);
        continue_button.onClick.AddListener(OnContinue);
        new_game_button.onClick.AddListener(OnNewGame);
        exit_button.onClick.AddListener(OnExit);
    }

    void TogglePauseActive(){
        pause_menu.SetActive(!pause_menu.activeSelf);
    }

    void OnContinue(){
        Debug.Log("----- CONTINUE PRESSED ----- ");
        Debug.Log("----- Read save file, load player position, region");
        Debug.Log("----- Load NPC and story states");
        Debug.Log("----- Load journal contents, conclusions, testimonies, evidence");
        Debug.Log("----- Load inventory");
        Debug.Log("----- Load the log, all completed tasks, all tasks yet to be completed");
        Debug.Log("-----");
    }

    void OnNewGame(){
        SceneManager.LoadScene("BurrowsHubEnvironment");
        Debug.Log("----- NEW GAME PRESSED ----- ");
        Debug.Log("----- Pick the save slot with no data, if all are taken, pick the one with the oldest data");
        Debug.Log("----- Set up the start of the story, put the player and NPCs in place");
        Debug.Log("----- Init empty journal");
        Debug.Log("----- Init empty inventory");
        Debug.Log("----- Init epmty log");
        Debug.Log("-----");
    }

    void OnSettings(){
        Debug.Log("----- SETTINGS PRESSED ----- ");
        Debug.Log("----- Read settings values from memory");
        Debug.Log("----- Set the setting values in the UI");
        Debug.Log("----- Set those values in game if changed");
        Debug.Log("-----");
    }

    void OnExit(){
        Debug.Log("----- EXIT BUTTON PRESSED -----");
        Debug.Log("----- Save game data");
        Debug.Log("----- Exit game");
        Debug.Log("-----");
    }
}
