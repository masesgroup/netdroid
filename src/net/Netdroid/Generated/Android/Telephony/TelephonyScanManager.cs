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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony
{
    #region TelephonyScanManager
    public partial class TelephonyScanManager
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

        #endregion

        #region Nested classes
        #region NetworkScanCallback
        public partial class NetworkScanCallback
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
            /// <see href="https://developer.android.com/reference/android/telephony/TelephonyScanManager.NetworkScanCallback.html#onComplete()"/>
            /// </summary>
            public void OnComplete()
            {
                IExecuteWithSignature("onComplete", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/TelephonyScanManager.NetworkScanCallback.html#onError(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnError(int arg0)
            {
                IExecuteWithSignature("onError", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/TelephonyScanManager.NetworkScanCallback.html#onResults(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public void OnResults(Java.Util.List<Android.Telephony.CellInfo> arg0)
            {
                IExecuteWithSignature("onResults", "(Ljava/util/List;)V", arg0);
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