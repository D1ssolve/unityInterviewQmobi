using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    #region Fields
    public static int scoreValue = 0;
    Text score;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out Text text);
        score = text;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
