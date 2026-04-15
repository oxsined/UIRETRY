//More code by Robin (and StackOverflow but ignore that)

using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isHovered;

    [SerializeField] public Color BackgroundColour;

    private void Start()
    {
        BackgroundColour.a = 1f;
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