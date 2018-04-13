using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // Access to Serializable classes

public class Game_Constructor : MonoBehaviour
{
    public bool bPrintDebug = false;
    public Question[] questions;

    private void Start()
    {
        //GenerateQuestion();
    }

    private void GenerateQuestion()
    {
        if (bPrintDebug)
            Debug.Log("Questions length = " + questions.Length);
        // 'q' equals Question index
        for (int q = 0; q < questions.Length; q++)
        {
            // 'a' equals Answer index within questions
            for (int a = 0; a < questions[q].answers.Length; a++)
            {
                if (bPrintDebug)
                    Debug.Log("Answer " + (a + 1) + ": " + questions[q].answers[a]);
            }

            // 'i' equals Implications within questions
            for (int i = 0; i < questions[q].implication.Length; i++)
            {
                if (bPrintDebug)
                    Debug.Log("Implication " + (i + 1) + ": " + questions[q].implication[i]);
            }

            // 'p' equals Points within questions
            for (int p = 0; p < questions[q].points.Length; p++)
            {
                if (bPrintDebug)
                    Debug.Log("Points " + (p + 1) + ": " + questions[q].points[p]);
            }
        }
    }
}
