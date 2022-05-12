using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CollectApple : MonoBehaviour
{
    private int Apple = 0;
    [SerializeField] private Text ScoreText;
    private void OnTriggerEnter2D(Collider2D collistion) {
        if (collistion.gameObject.CompareTag("Spawnable"))
        {
            Destroy(collistion.gameObject);
            Apple++;
            //Debug.Log(Apple);
            ScoreText.text = "Apple: " + Apple;
        }
    }
}
