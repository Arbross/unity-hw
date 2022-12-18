using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    /// <summary>
    /// Image we are using
    /// </summary>
    public Image bar;

    /// <summary>
    /// Filling of HP bar
    /// </summary>
    public float fill;

    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (fill >= 0)
        {
            fill -= (float)(Time.fixedDeltaTime * 0.1);
        }
        else
        {
            fill = 1f;
        }

        bar.fillAmount = fill;
    }
}
