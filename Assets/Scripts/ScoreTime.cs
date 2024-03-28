using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{  
    //Movement
    public Rigidbody2D rb;
    public float sideSpeed;
    public float maxPos = 5.5f;
    public GameObject highPlusSound;

    //Score
    int score;
    public Text scoreText;
    public Text highScoreText;
    public GameObject hJinish;
    public GameObject highShow;

    //AddOns
    bool startColorTime = false;
    float colorTime = 0f;
    bool powStartTime = false;
    float changeTime = 0f;
    string powText = "";
    public Text powTextShow;
    //power vars
    int basketSize = 1;
    int scoreMulti = 1;
    int moveDir = 1;

    //bonuses
    int coinCollect = 0;//plus 10 for consecutive 5 coins
    public GameObject coinCollectText;
    float coinTextTime = 0f;
    bool showCoinText = false;
    int garCollect = 0;//minus 10 for consecutive 5 garbages
    public GameObject garCollectText;
    bool showGarText = false;
    float garTextTime = 0f;
    int powCollect = 0;//plus 20 for collecting all addOns
    bool fellOrRot = false;
    public Text fellRotText;
    public Text powCollectText;
    //bonus panel
    public GameObject bPanel;

    //timer for highscore check
    public float timer;
    bool stopTimer = false;

    //Time Over music
    public GameObject deadTime;
    public GameObject sounds1;
    public GameObject sounds2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        highScoreText.text = PlayerPrefs.GetInt("HighScoreTime").ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

            if (Input.GetMouseButton(0))
            {
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (moveDir * touchPos.x < 0)
                {
                    rb.velocity = Vector2.left * sideSpeed;
                }
                if (moveDir * touchPos.x > 0)
                {
                    rb.velocity = Vector2.right * sideSpeed;
                }
            }
            if (transform.position.y < -4.5)
            {
                fellOrRotScore();
            }
            if (transform.eulerAngles == Vector3.forward * 180)
            {
                fellOrRotScore();
            }  
    }
    void Update() {
        scoreText.text = score.ToString();
        if(!stopTimer)
            timer -= Time.deltaTime;

        if (timer < 0f)
        { 
            //Bonuses show
            if (powCollect == 4) {
                score += 20;
                powCollectText.color = Color.green;
            }
            if (!fellOrRot) {
                score += 20;
                fellRotText.color = Color.green;
            }
            bPanel.SetActive(true);
            timer = 10;
            stopTimer = true;
            hJinish.SetActive(true);
            if (score > PlayerPrefs.GetInt("HighScoreTime", 0))
            {
                PlayerPrefs.SetInt("HighScoreTime", score);
                highScoreText.text = score.ToString();
                highPlusSound.SetActive(true);
                highShow.SetActive(true);
                timer = 10;
                stopTimer = true;
            }
        }

        //AddOns
        //color
        if (startColorTime) {
            colorTime += Time.deltaTime;
        }
        if (colorTime >= 2f) {
            scoreText.color = Color.black;
            powText = "";
            startColorTime = false;
            colorTime = 0f;
        }

        //Power stays for 10 secs
        if (powStartTime) {
            changeTime += Time.deltaTime;
        }
        if (changeTime >= 10) {
            powStartTime = false;
            //returning the nrml values
            basketSize = 1;
            scoreMulti = 1;
            moveDir = 1;
            powText = "";
            changeTime = 0;
        }
        if (basketSize == 2) {
            transform.localScale = new Vector3(0.17702f, 0.1132f, 1f);
        }
        else if (basketSize == 1) {
            transform.localScale = new Vector3(0.08851f, 0.11332f, 1f);
        }
        powTextShow.text = powText;

        //Bonuses
        if (coinCollect == 5) {
            score += 10;
            showCoinText = true;
            coinCollect = 0;
        }
        if (showCoinText) {
            coinTextTime += Time.deltaTime;
            coinCollectText.SetActive(true);
        }
        if (coinTextTime >= 1.5f) {
            coinCollectText.SetActive(false);
            showCoinText = false;
            coinTextTime = 0f;
        }
        if (garCollect == 5)
        {
            score -= 10;
            showGarText = true;
            garCollect = 0;
        }
        if (showGarText)
        {
            garTextTime += Time.deltaTime;
            garCollectText.SetActive(true);
        }
        if (garTextTime >= 1.5f)
        {
            garCollectText.SetActive(false);
            showGarText = false;
            garTextTime = 0f;
        }
        if (timer <= 5f) {
            deadTime.SetActive(true);
            sounds1.SetActive(false);
            sounds2.SetActive(false);
        }
    }
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "coin") {
            scoreUpdateCoin();
        }
        if (coll.gameObject.tag == "garbage")
        {
            scoreUpdateGarbage();
        }
        if (coll.gameObject.name == "powQues(Clone)")
        {
            int randomNum = Random.Range(0, 2);
            if (randomNum == 0)
            {
                score -= 25;
                scoreText.color = new Color(0.8f,0,0);
                powText = "-25";
            }
            else
            {
                score += 25;
                scoreText.color = new Color(0, 0.8f, 0);
                powText = "+25";
            }
            startColorTime = true;
            powCollect++;
        }
        if (coll.gameObject.name == "powBasket(Clone)")
        {
            basketSize = 2;
            powStartTime = true;
            powText = "Size 2x";
            powCollect++;
        }
        if (coll.gameObject.name == "pow2x(Clone)")
        {
            scoreMulti = 2;
            powStartTime = true;
            powText = "2x score";
            powCollect++;
        }
        if (coll.gameObject.name == "powArrow(Clone)")
        {
            moveDir = -1;
            powStartTime = true;
            powText = "Altered Movement";
            powCollect++;
        }
    }
    public void scoreUpdateCoin() {
        score += scoreMulti*1;
        coinCollect++;
        garCollect = 0;
    }
    public void scoreUpdateGarbage() {
        score -= scoreMulti * 1;
        coinCollect = 0;
        garCollect++;
    }
    public void fellOrRotScore() {
        score -= scoreMulti * 15;
        audioManager.PlaySound("garbages");
        Vector3 spawnPos = new Vector3(0f , -3.807867f , -3.11f);
        transform.position = spawnPos;
        transform.eulerAngles = Vector3.forward * 0;
        coinCollect = 0;
        garCollect = 0;
        fellOrRot = true;
    }
    public void resetScoreTime()
    {
        highScoreText.text = 0.ToString();
        PlayerPrefs.DeleteKey("HighScoreTime");
    }
}
