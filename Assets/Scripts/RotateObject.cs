using UnityEngine;

public class RotateObject : MonoBehaviour

{
    [SerializeField] private float rotationSpeed = 200.0f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1,0), rotationSpeed * Time.deltaTime);
    }
}
