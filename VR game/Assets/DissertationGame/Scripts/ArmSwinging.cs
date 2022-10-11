using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ArmSwinging : DeviceBasedContinuousMoveProvider
{
    //public GameObject forwardDirection;
    //public GameController centerEyeCamera;

    /*
    private void Update()
    {
        //Get the forward direction
        float yRotation = centerEyeCamera.transform.eulerAngles.y;
        forwardDirection.transform.eulerAngles = new Vector3(0, yRotation, 0);
    }
    */

    protected override Vector2 ReadInput()
    {
        if (controllers.Count == 0)
            return Vector2.zero;

        // Accumulate all the controller inputs
        var input = Vector2.zero;
        var feature = CommonUsages.deviceVelocity;
        //var featureActive = CommonUsages.triggerButton;
        var featureActive = CommonUsages.primaryButton;

        for (var i = 0; i < controllers.Count; ++i)
        {
            var controller = controllers[i] as XRController;
            if (controller != null &&
                controller.enableInputActions &&
                controller.inputDevice.TryGetFeatureValue(feature, out var controllerVelocity))
            {
                controller.inputDevice.TryGetFeatureValue(featureActive, out var triggerActive);
                if (triggerActive)
                {
                    Vector2 controllerInput = new Vector2(controllerVelocity.x, controllerVelocity.z);
                    input -= GetDeadzoneAdjustedValue(controllerInput);
                    //transform.position += forwardDirection.transform.forward * controllerVelocity.x * controllerVelocity.y;
                }
            }
        }

        return input;
    }
}
