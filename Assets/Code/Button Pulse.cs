//Code by Robin (I know, shocker :O)

using UnityEngine;

public class ButtonPulse : MonoBehaviour
{
    private ButtonHover buttonHoverDetector;
    private Vector3 baseSize;

    [SerializeField] private float pulseAmount = 0.05f; //Max grow/shrink
    [SerializeField] private float pulseSpeed = 1f; //Grow/shrink speed

    private float timer; //zodat hij weet hoever hij in de "animatie" zit

    void Start()
    {
        baseSize = transform.localScale;
        buttonHoverDetector = GetComponent<ButtonHover>();
    }

    void Update()
    {
        if (buttonHoverDetector != null && buttonHoverDetector.isHovered)
        {
            timer += Time.deltaTime * pulseSpeed;

            float scaleOffset = Mathf.Sin(timer) * pulseAmount; //neemt de movement maar maakt het smooth (vraag StackOverflow idk)
            transform.localScale = baseSize * (1f + scaleOffset); //pas de lijn hier boven toe
        }
        else
        {
            timer = 0f;
            transform.localScale = baseSize;
            //reset waardes als er niet op word gehoverd
        }
    }
}