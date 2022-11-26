using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// INHERITANCE
public class SceneLoander : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(DelaySceneLoander());
    }
    IEnumerator DelaySceneLoander()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
