using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class NearFarModeToggle : MonoBehaviour
{
    [SerializeField]
    private NearFarInteractor nearFarInteractor;

    public void SetFarAttachMode(bool enableFarAttach)
    {
        if (nearFarInteractor == null)
        {
            Debug.LogWarning("NearFarModeToggle: No hay NearFarInteractor asignado.");
            return;
        }

        nearFarInteractor.enabled = enableFarAttach;
    }
}