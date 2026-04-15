//Code by Robin =D

using UnityEngine;
using UnityEngine.UI;

public class BGcolourswap : MonoBehaviour
{
    private RawImage thisImage;

    [SerializeField] private Button[] buttons;
    //Buttons: 0 = 2D Work   1 = 3D Work   2 = Envoirments   3 = Projects

    void Start()
    {
        thisImage = GetComponent<RawImage>();
    }

    void Update()
    {
        thisImage.color = Color.white;
        foreach (var button in buttons)
        {
            if (button.GetComponent<ButtonHover>().isHovered)
            {
                thisImage.color = button.GetComponent<ButtonHover>().BackgroundColour;
            }
        }
    }
}
