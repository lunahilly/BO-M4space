using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class VisualHit : MonoBehaviour
{
    public SpriteRenderer rend;

    // Start is called before the first frame update



    private IEnumerator Hit(float time)
    {
        rend.color = Color.red;
        yield return new WaitForSeconds(time);
    }


}
