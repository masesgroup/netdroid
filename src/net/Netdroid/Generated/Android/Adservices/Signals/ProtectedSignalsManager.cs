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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Adservices.Signals
{
    #region ProtectedSignalsManager
    public partial class ProtectedSignalsManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/signals/ProtectedSignalsManager.html#get(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Adservices.Signals.ProtectedSignalsManager"/></returns>
        public static Android.Adservices.Signals.ProtectedSignalsManager Get(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Adservices.Signals.ProtectedSignalsManager>(LocalBridgeClazz, "get", "(Landroid/content/Context;)Landroid/adservices/signals/ProtectedSignalsManager;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/signals/ProtectedSignalsManager.html#updateSignals(android.adservices.signals.UpdateSignalsRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Signals.UpdateSignalsRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void UpdateSignals(Android.Adservices.Signals.UpdateSignalsRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("updateSignals", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}