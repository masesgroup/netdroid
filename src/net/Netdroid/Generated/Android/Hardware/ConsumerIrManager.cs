/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware
{
    #region ConsumerIrManager
    public partial class ConsumerIrManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/ConsumerIrManager.html#getCarrierFrequencies()"/> 
        /// </summary>
        public Android.Hardware.ConsumerIrManager.CarrierFrequencyRange[] CarrierFrequencies
        {
            get { return IExecuteWithSignatureArray<Android.Hardware.ConsumerIrManager.CarrierFrequencyRange>("getCarrierFrequencies", "()[Landroid/hardware/ConsumerIrManager$CarrierFrequencyRange;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/ConsumerIrManager.html#hasIrEmitter()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasIrEmitter()
        {
            return IExecuteWithSignature<bool>("hasIrEmitter", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/ConsumerIrManager.html#transmit(int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Transmit(int arg0, int[] arg1)
        {
            IExecute("transmit", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region CarrierFrequencyRange
        public partial class CarrierFrequencyRange
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/ConsumerIrManager.CarrierFrequencyRange.html#%3Cinit%3E(android.hardware.ConsumerIrManager,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.ConsumerIrManager"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public CarrierFrequencyRange(Android.Hardware.ConsumerIrManager arg0, int arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/ConsumerIrManager.CarrierFrequencyRange.html#getMaxFrequency()"/> 
            /// </summary>
            public int MaxFrequency
            {
                get { return IExecuteWithSignature<int>("getMaxFrequency", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/ConsumerIrManager.CarrierFrequencyRange.html#getMinFrequency()"/> 
            /// </summary>
            public int MinFrequency
            {
                get { return IExecuteWithSignature<int>("getMinFrequency", "()I"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}