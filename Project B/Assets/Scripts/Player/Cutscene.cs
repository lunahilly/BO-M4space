using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject button;
    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        rend = GetComponent<SpriteRenderer>();
        startFading();

    }

    // Update is called once per frame
    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(5f);
        for (float f = 1f; f >= -0.05f; f -= 0.05f) 
        { 
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        StartCoroutine(FadeOut());
        button.SetActive(true);
    }
}
