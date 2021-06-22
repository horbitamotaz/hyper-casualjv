using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int score1 = 0;

   private void Start()
    {
        score1 = 0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score1.ToString();
    }
}
