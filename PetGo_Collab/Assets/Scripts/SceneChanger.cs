using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void goToilet() {
        SceneManager.LoadScene("Toilet");
    }
    public void goMain() {
        SceneManager.LoadScene("Main scene");
    }
}
