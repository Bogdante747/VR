using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    public GameObject prefabTarget;

    public void NewTarget()
    {
        StartCoroutine(DelayCreate());
    }

    private IEnumerator DelayCreate()
    {
        yield return new WaitForSeconds(2f);
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 1f);
        Vector3 newPos = new Vector3(x, y, z);
        Transform currentTarget = Instantiate(prefabTarget, transform.position + newPos, transform.rotation).transform;
        currentTarget.parent = transform;
    }
}
