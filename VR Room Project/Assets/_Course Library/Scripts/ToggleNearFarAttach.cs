using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ToggleNearFarAttach : MonoBehaviour
{
    [SerializeField]
    private NearFarInteractor nearFarInteractor;

    public NearFarInteractor NearFarInteractor => nearFarInteractor;
}