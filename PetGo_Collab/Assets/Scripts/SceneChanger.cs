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
    public void goLivingRoom() {
        SceneManager.LoadScene("LivingRoom");
    }
    public void goBedroom() {
        SceneManager.LoadScene("Bedroom");
    }
    public void goFeedingRoom() {
        SceneManager.LoadScene("FeedingRoom");
    }
    public void goOutside() {
        SceneManager.LoadScene("Outside");
    }
}
