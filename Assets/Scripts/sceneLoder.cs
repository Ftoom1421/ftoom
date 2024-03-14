using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoder : MonoBehaviour
{
    // Start is called before the first frame update

    // public void Start()
    // {
    //     DontDestroyOnLoad(gameObject);
    // 
    // لو حطينه هنا حيكون في نفس اللعبه ظاهر لان السكربت جزء من اللعبه 
    //  اما لو كتبته في سكربت مختلف وحطيته في ايمتي اوبجكت حيكون خارج اللعبه لمن اضغط يختفي زي الالعاب اللي فيها صفحه وحده بعدين تختفي

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
