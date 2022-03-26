using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionScript : MonoBehaviour
{
    public MovementScript movementscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="Enemy")
        {
            movementscript.enabled = false;
            Invoke("ResetGame", 2f);
        }
    }
    void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
