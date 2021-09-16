using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerCustom : MonoBehaviour
{
    public int totalItemCount;
    public int stage;
    public Text stageItemText;
    public Text playerItemText;

    void Awake() {
        stageItemText.text = "/ " + totalItemCount;
    }

    public void GetItem(int count) {
        playerItemText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player") {
            SceneManager.LoadScene(stage);
        }
    }
}
