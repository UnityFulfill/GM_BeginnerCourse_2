using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerCustom : MonoBehaviour
{
    public int totalItemCount;
    public int stage;

    private void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player") {
            SceneManager.LoadScene(stage);
        }
    }
}
