using UnityEngine;
using UnityEngine.UI;

public class PickupCollect : MonoBehaviour
{
    //Battery collect logic
    public static int pickupAmount = 0;

    //Holds the images
    public static RawImage hud;

    //Battery sprites
    [SerializeField] Texture pickup1tex;
    [SerializeField] Texture pickup2tex;
    [SerializeField] Texture pickup3tex;
    [SerializeField] Texture pickup4tex;
    [SerializeField] Texture pickup0tex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the Image GameObject
        hud = gameObject.GetComponentInChildren<RawImage>();

        // Hide the Image on start
        hud.enabled = false;

        // Set initial pickup amount
        pickupAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(pickupAmount == 1)
        {
            hud.texture = pickup1tex;
            hud.enabled = true;
        }
        else if(pickupAmount == 2)
        {
            hud.texture = pickup2tex;
        }
        else if(pickupAmount == 3)
        {
            hud.texture = pickup3tex;
        }
        else if(pickupAmount == 4)
        {
            hud.texture = pickup4tex;
        }
        else
        {
            hud.texture = pickup0tex;
        }
    }
}
