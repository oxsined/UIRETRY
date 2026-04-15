//Code by Robin =D

using UnityEngine;
using UnityEngine.UI;

public class BGcolourswap : MonoBehaviour
{
    private RawImage backgroundImage;

    [SerializeField] Button[] buttons;
    //Buttons: 0 = 2D Work   1 = 3D Work   2 = Envoirments   3 = Projects

    void Start()
    {
        //selecteer de achtergrond
        backgroundImage = GetComponent<RawImage>();
    }

    void Update()
    {
        backgroundImage.color = Color.white;
        //eerst zet je de kleur op wit (makkelijker dan checken of je op niks hoverd)

        foreach (var button in buttons) //check alle buttons
        {
            if (button.GetComponent<ButtonHover>().isHovered)
            {
                backgroundImage.color = button.GetComponent<ButtonHover>().BackgroundColour;
                //als je op een button hoverd zet het de achtergrond kleur op de kleur die staat op die button in het ButtonHover script
            }
        }
    }
}