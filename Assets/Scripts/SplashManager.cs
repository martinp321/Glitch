using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadStartScene());
    }

    IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Start");
    }
}
