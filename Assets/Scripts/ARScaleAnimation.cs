using UnityEngine;
using Vuforia;

public class ARScaleAnimation : MonoBehaviour
{
    public GameObject arContent;
    public float animationDuration = 0.5f;
    private Vector3 targetScale;

    private ObserverBehaviour observerBehaviour;

    private void Awake()
    {
        observerBehaviour = GetComponent<ObserverBehaviour>();

        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        if (arContent != null)
        {
            targetScale = arContent.transform.localScale;
            arContent.transform.localScale = Vector3.zero;
            arContent.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            OnTargetFound();
        }
        else
        {
            OnTargetLost();
        }
    }

    private void OnTargetFound()
    {
        if (arContent != null)
        {
            arContent.SetActive(true);
            StopAllCoroutines();
            StartCoroutine(ScaleObject(arContent, Vector3.zero, targetScale, animationDuration));
        }
    }

    private void OnTargetLost()
    {
        if (arContent != null)
        {
            StopAllCoroutines();
            arContent.SetActive(false);
            arContent.transform.localScale = Vector3.zero;
        }
    }

    private System.Collections.IEnumerator ScaleObject(GameObject obj, Vector3 from, Vector3 to, float duration)
    {
        float elapsed = 0;
        while (elapsed < duration)
        {
            obj.transform.localScale = Vector3.Lerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        obj.transform.localScale = to;
    }
}
