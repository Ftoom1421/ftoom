
using UnityEngine;

public class TimeManger : MonoBehaviour
{

    public float slowdownFactor = 0.0f;
    public float slowdownLength = 2f;

    void DoSlowmotion()
    {
        Time.timeScale = slowdownFactor;

    }
}

// Start is called before the first frame update
