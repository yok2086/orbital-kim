using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
    public Animator transition; 
    public float transitionTime = 1f; 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator Loadlevel(int levelIndex)
    {
        // play animation
        transition.SetTrigger("start");
        // wait
        yield return new WaitForSeconds(1);
        // load scene 
        SceneManager.LoadScene(levelIndex);
    }
}
