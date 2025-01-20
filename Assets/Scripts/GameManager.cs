using TMPro;
using UnityEngine;
using System.Runtime.InteropServices;

public class GameManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void UnityToNextJS(string userName, int score);

    public TMP_InputField userInput;
    public TextMeshProUGUI text;

    private int score;

    private void Start()
    {
        score = 0;
    }

    public void CallByNextJS(string message)
    {
        text.text = message;
    }

    public void OnNextJSButtonClick()
    {
        score += 100;
#if UNITY_WEBGL && !UNITY_EDITOR
        UnityToNextJS(userInput.text, score);
#endif
    }
}