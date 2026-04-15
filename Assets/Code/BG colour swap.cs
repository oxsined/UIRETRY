//Code by Robin =D

using UnityEngine;
using UnityEngine.UI;

public class BGcolourswap : MonoBehaviour
{
    [SerializeField] float colourSwapSpeed;

    private RawImage backgroundImage;

    private Color currentColour;
    private Color targetColour;

    [SerializeField] Button[] buttons;
    //Buttons: 0 = 2D Work   1 = 3D Work   2 = Envoirments   3 = Projects

    void Start()
    {
        //selecteer de achtergrond
        backgroundImage = GetComponent<RawImage>();
        currentColour = Color.white; // initialize to your default background colour
    }

    void Update()
    {
        backgroundImage.color = currentColour;

        targetColour = Color.white;
        //zet de kleur op wit (makkelijker dan checken of je op niks hoverd)

        foreach (var button in buttons) //check alle buttons
        {
            if (button.GetComponent<ButtonHover>().isHovered)
            {
                targetColour = button.GetComponent<ButtonHover>().BackgroundColour;
                //als je op een button hoverd zet het de achtergrond kleur op de kleur die staat op die button in het ButtonHover script
            }
        }

        if (targetColour != currentColour)
        {
            currentColour = Color.Lerp(currentColour, targetColour, colourSwapSpeed * Time.deltaTime);
            //smooth fade naar de target kleur
        }
    }
}