using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
         //   print("awake"); 
            //m_Car.Move(0, 0, 0, 1);

        }
        


        private void FixedUpdate()
        {

            // pass the input to the car!

			//when using android (set to android)
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");

			//when testing with keyboard (but target set to android)
			float h = Input.GetAxis("Horizontal");
			float v = Input.GetAxis("Vertical");


			#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
			float handbrake = Input.GetAxis("Jump");
			m_Car.Move(h, v, v, handbrake);
#endif
        }
    }
}
