using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private Button button;

    void Start(){
        // This needs to be here so that the cursor becomes visible on the title screen
        Cursor.visible = true;
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayGame);
    }

    void PlayGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }
}