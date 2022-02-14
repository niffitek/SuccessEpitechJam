using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuoteRandomizer : MonoBehaviour
{
    private string[] quotes =
    {
        "\"Successful people do what unsuccessful people are not willing to do. Don't wish it were easier; wish you were better.\" - Jim Rohn",
        "\"Success is walking from failure to failure with no loss of enthusiasm.\" - Winston Churchill",
        "\"If you really look closely, most overnight successes took a long time.\" - Steve Jobs",
        "\"The successful warrior is the average man, with laser-like focus.\" - Bruce Lee",
        "\"Success is not the key to happiness. Happiness is the key to success. If you love what you are doing, you will be successful.\" - Albert Schweitzer",
        "\"Keep our competitors focused on us, while we stay focused on the customer.\" - Jeff Bezos",
        "\"Patience is a key element of success.\" - Bill Gates",
        "\"It’s fine to celebrate success, but it is more important to heed the lessons of failure.\" - Bill Gates",
        "\"If you stop getting better, you stop being good\" - Philip Rosenthal"
    };

    void Start()
    {
        GetComponent<TMP_Text>().text = quotes[Random.Range(0, quotes.Length)];
    }
} 
