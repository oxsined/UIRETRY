using UnityEngine;
using UnityEngine.UI; // For UI Text
using TMPro;          // For TextMeshPro (optional)

public class CurrentTimeDisplay : MonoBehaviour
{
    [Header("UI References")]
    public Text uiText;           // Assign if using legacy UI Text
    public TextMeshProUGUI tmpText; // Assign if using TextMeshPro

    [Header("Time Format")]
    public string timeFormat = "HH:mm:ss"; // 24-hour format. Use "hh:mm:ss tt" for 12-hour with AM/PM

    void Update()
    {
        // Get current system time
        string currentTime = System.DateTime.Now.ToString(timeFormat);

        // Update UI Text if assigned
        if (uiText != null)
            uiText.text = currentTime;

        // Update TextMeshPro if assigned
        if (tmpText != null)
            tmpText.text = currentTime;
    }
}
