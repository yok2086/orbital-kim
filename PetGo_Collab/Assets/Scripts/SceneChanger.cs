using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void goToilet() {
        SceneManager.LoadScene("Toilet");
    }
    public void goMain() {
        SceneManager.LoadScene("Main scene");
    }
    public void goBed() {
        SceneManager.LoadScene("Bedroom");
    }

    public void goOut()
    {
        SceneManager.LoadScene("Outside");
    }

    public void goEat()
    {
        SceneManager.LoadScene("FeedingRoom");
    }
}
