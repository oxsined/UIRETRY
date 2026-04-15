//Code by Robin (I know, shocker :O)

using UnityEngine;

public class ButtonPulse : MonoBehaviour
{
    private ButtonHover buttonHoverDetector;
    private Vector3 baseSize;

    [SerializeField] private float pulseAmount = 0.05f;
    [SerializeField] private float pulseSpeed = 1f;

    private float timer;

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

            float scaleOffset = Mathf.Sin(timer) * pulseAmount;
            transform.localScale = baseSize * (1f + scaleOffset);
        }
        else
        {
            timer = 0f;
            transform.localScale = baseSize;
        }
    }
}