using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoder : MonoBehaviour
{
    // Start is called before the first frame update

    public void SceneLoder1()
    {
        StartCoroutine(ClicCorotine("FirstWorld"));
    }
    public void SceneLoder2()
    {
        StartCoroutine(ClicCorotine("tmtom"));
    }
    private IEnumerator ClicCorotine(string sceneName)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
        while (!op.isDone)
            yield return null;
    }

}
