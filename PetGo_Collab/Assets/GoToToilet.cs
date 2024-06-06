using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToToilet : MonoBehaviour
{
    // Start is called before the first frame update
    public void goToilet() {
        SceneManager.LoadScene("Toilet");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
