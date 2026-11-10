using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float maxSpeed = 7f;

    private Rigidbody rb;

    private int count = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public GameObject winPanel;

    public TextMeshProUGUI loseText;
    public GameObject losePanel;

    public GameObject instructionPanel;
    private bool gameStarted = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreText.text = "Score: 0 / 16";
        winText.gameObject.SetActive(false);
        winPanel.SetActive(false);

        loseText.gameObject.SetActive(false);
        losePanel.SetActive(false);

        instructionPanel.SetActive(false);
        Time.timeScale = 1f;
        gameStarted = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(
            moveHorizontal,
            0.0f,
            moveVertical
        );

        rb.AddForce(movement * speed);

        // Limit horizontal speed
        Vector3 horizontalVelocity =
            new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

        if (horizontalVelocity.magnitude > maxSpeed)
        {
            Vector3 limitedVelocity =
                horizontalVelocity.normalized * maxSpeed;

            rb.linearVelocity = new Vector3(
                limitedVelocity.x,
                rb.linearVelocity.y,
                limitedVelocity.z
            );
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

            count++;

            scoreText.text = "Score: " + count + " / 16";
            if (count >= 16)
            {
                winText.gameObject.SetActive(true);
                winPanel.SetActive(true);

                rb.linearVelocity = Vector3.zero;
                Time.timeScale = 0f;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            loseText.gameObject.SetActive(true);
            losePanel.SetActive(true);

            rb.linearVelocity = Vector3.zero;
            Time.timeScale = 0f;
        }
    }
}