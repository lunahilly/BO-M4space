using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    SpriteRenderer rend;
    public float wait;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        startFading();
    }

    IEnumerator Fadein()
    {
        for (float f = 0.5f; f <= 1f; f += 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(wait);
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

        StartCoroutine(Fadein());
        StartCoroutine(FadeOut());
    }
}
