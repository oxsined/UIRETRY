//More code by Robin (and StackOverflow but ignore that)

using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isHovered;

    [SerializeField] public Color BackgroundColour;
    //Voor het BGcolourswap script ^^^^^

    private void Start()
    {
        BackgroundColour.a = 1f;
        //zet de alpha op 1 zodat het niet onzichtbaar word
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovered = false;
    }
}