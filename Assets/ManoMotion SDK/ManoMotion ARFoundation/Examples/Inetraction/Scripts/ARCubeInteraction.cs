using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARCubeInteraction : MonoBehaviour
{

    //declaration of hand gestures
    private ManoGestureContinuous grab;
    private ManoGestureContinuous pinch;
    private ManoGestureTrigger click;

    [SerializeField]
    private Material[] arCubeMaterial;

    private string handTag = "Player";
    private Renderer cubeRenderer;

    public GameObject DetailPanel;
    public GameObject elementDetails;
    public GameObject PeriodicTable;
    public GameObject backButton;

    private float skeletonConfidenceThreshold = 0.0001f;

    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        grab = ManoGestureContinuous.CLOSED_HAND_GESTURE;
        pinch = ManoGestureContinuous.HOLD_GESTURE;
        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
        cubeRenderer.material = arCubeMaterial[0];
    }
    private void Update()
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info.skeleton.confidence < skeletonConfidenceThreshold)
        {
            cubeRenderer.sharedMaterial = arCubeMaterial[0];

            if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == grab)
                PeriodicTable.transform.Rotate(Vector3.up * Time.deltaTime * 30, Space.World);
            else
                transform.parent = null;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == handTag)
            cubeRenderer.sharedMaterial = arCubeMaterial[1];
        
        //GrabRotate(other);
        PinchDetails(other);
    }
    /*private void GrabRotate(Collider other)
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == grab)
            PeriodicTable.transform.Rotate(Vector3.up * Time.deltaTime * 50, Space.World);
        else
            transform.parent = null;
    }*/
    private void PinchDetails(Collider other)
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == pinch)
            DetailPanel.SetActive(true);
            elementDetails.SetActive(true);
            //backButton.SetActive(false);
    }

    /// <summary>
    /// Vibrate when hand collider enters the cube.
    /// </summary>
    /// <param name="other">The collider that enters</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == handTag)
        {
            cubeRenderer.sharedMaterial = arCubeMaterial[1];
            Handheld.Vibrate();
        }
    }

    /// <summary>
    /// Change material when exit the cube
    /// </summary>
    /// <param name="other">The collider that exits</param>
    private void OnTriggerExit(Collider other)
    {
        cubeRenderer.sharedMaterial = arCubeMaterial[0];
    }
}