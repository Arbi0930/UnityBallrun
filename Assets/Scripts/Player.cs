using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Touch touch;
    public float speed;
    public float speedController;
    public Text scoreText;
    public Text scoreText2;
    public float score;
    public GameObject gameoverpanel;
    public bool isGameOver;
    private void Awake()
    {
        isGameOver = false;
        score = 0;
        if(PlayerPrefs.GetFloat("Хамгийн өндөр оноо") == 0){
            PlayerPrefs.GetFloat("Хамгийн өндөр оноо", 0);

        }
        PlayerPrefs.GetFloat("Таны оноо: ", score);
    }

    void Start()
    {
        score = 0;
        speedController = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false) { score++; }
        scoreText.text = "Таны оноо: " + score;
        scoreText2.text = "Таны оноо: " + score;
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -2f)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 3f)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime); 
        }


        transform.Translate(Vector3.forward * speed * Time.deltaTime); 

        if(Input.touchCount > 0 && transform.position.x >= -3f && transform.position.x <= 3f)
        {
            touch = Input.GetTouch(0);
            transform.Translate(touch.deltaPosition.x * speedController, 0, 0);
        }
        else if(transform.position.x > 3f)
        {
            transform.position = new Vector3(3f, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < -3f)
        {
            transform.position = new Vector3(-3f, transform.position.y,transform.position.z);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            isGameOver = true;
            gameoverpanel.SetActive(true);
            Time.timeScale = 0f; 
        }
        if(PlayerPrefs.GetFloat("Хамгийн өндөр оноо") < score)
        {
            PlayerPrefs.SetFloat("Хамгийн өндөр оноо", score);
        }
        else
        {
            PlayerPrefs.GetFloat("Таны оноо:", score);
        }
    }
}
