using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Life : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
     private void OnTriggerEnter2D(Collider2D collistion) 
    {
        if (collistion.gameObject.CompareTag("Durian"))
        {
            Destroy(collistion.gameObject);
            Die();
            Restartlevel();
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
    }
    private void Restartlevel()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
}
