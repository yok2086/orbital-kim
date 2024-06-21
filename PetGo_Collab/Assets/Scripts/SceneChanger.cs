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
<<<<<<< HEAD

    public void goOut()
    {
        SceneManager.LoadScene("Outside");
    }

    public void goEat()
    {
        SceneManager.LoadScene("FeedingRoom");
    }
=======
    public void goFeedingRoom() {
        SceneManager.LoadScene("FeedingRoom");
    }
    public void goOutside() {
        SceneManager.LoadScene("Outside");
    }
>>>>>>> 00c60600b2247c645aed609723c0d89494d45e3f
}
