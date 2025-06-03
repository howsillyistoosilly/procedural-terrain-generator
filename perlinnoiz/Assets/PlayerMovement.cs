using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5.0f;
    public MeshGenerator meshGenerator; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 spawnPos = meshGenerator.GetCenterPosition();
        transform.position = spawnPos + Vector3.up * 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float Xmove = Input.GetAxis("Horizontal");
        float zmove = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3(Xmove,0f,zmove) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
        

    }
}
