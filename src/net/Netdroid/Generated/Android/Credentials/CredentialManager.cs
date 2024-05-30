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

namespace Android.Credentials
{
    #region CredentialManager
    public partial class CredentialManager
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
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#isEnabledCredentialProviderService(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabledCredentialProviderService(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<bool>("isEnabledCredentialProviderService", "(Landroid/content/ComponentName;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#clearCredentialState(android.credentials.ClearCredentialStateRequest,android.os.CancellationSignal,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Credentials.ClearCredentialStateRequest"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void ClearCredentialState(Android.Credentials.ClearCredentialStateRequest arg0, Android.Os.CancellationSignal arg1, Java.Util.Concurrent.Executor arg2, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Credentials.ClearCredentialStateException> arg3)
        {
            IExecute("clearCredentialState", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#createCredential(android.content.Context,android.credentials.CreateCredentialRequest,android.os.CancellationSignal,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Credentials.CreateCredentialRequest"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void CreateCredential(Android.Content.Context arg0, Android.Credentials.CreateCredentialRequest arg1, Android.Os.CancellationSignal arg2, Java.Util.Concurrent.Executor arg3, Android.Os.OutcomeReceiver<Android.Credentials.CreateCredentialResponse, Android.Credentials.CreateCredentialException> arg4)
        {
            IExecute("createCredential", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#getCredential(android.content.Context,android.credentials.GetCredentialRequest,android.os.CancellationSignal,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Credentials.GetCredentialRequest"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void GetCredential(Android.Content.Context arg0, Android.Credentials.GetCredentialRequest arg1, Android.Os.CancellationSignal arg2, Java.Util.Concurrent.Executor arg3, Android.Os.OutcomeReceiver<Android.Credentials.GetCredentialResponse, Android.Credentials.GetCredentialException> arg4)
        {
            IExecute("getCredential", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#getCredential(android.content.Context,android.credentials.PrepareGetCredentialResponse.PendingGetCredentialHandle,android.os.CancellationSignal,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Credentials.PrepareGetCredentialResponse.PendingGetCredentialHandle"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void GetCredential(Android.Content.Context arg0, Android.Credentials.PrepareGetCredentialResponse.PendingGetCredentialHandle arg1, Android.Os.CancellationSignal arg2, Java.Util.Concurrent.Executor arg3, Android.Os.OutcomeReceiver<Android.Credentials.GetCredentialResponse, Android.Credentials.GetCredentialException> arg4)
        {
            IExecute("getCredential", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#prepareGetCredential(android.credentials.GetCredentialRequest,android.os.CancellationSignal,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Credentials.GetCredentialRequest"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void PrepareGetCredential(Android.Credentials.GetCredentialRequest arg0, Android.Os.CancellationSignal arg1, Java.Util.Concurrent.Executor arg2, Android.Os.OutcomeReceiver<Android.Credentials.PrepareGetCredentialResponse, Android.Credentials.GetCredentialException> arg3)
        {
            IExecute("prepareGetCredential", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#registerCredentialDescription(android.credentials.RegisterCredentialDescriptionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Credentials.RegisterCredentialDescriptionRequest"/></param>
        public void RegisterCredentialDescription(Android.Credentials.RegisterCredentialDescriptionRequest arg0)
        {
            IExecuteWithSignature("registerCredentialDescription", "(Landroid/credentials/RegisterCredentialDescriptionRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialManager.html#unregisterCredentialDescription(android.credentials.UnregisterCredentialDescriptionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Credentials.UnregisterCredentialDescriptionRequest"/></param>
        public void UnregisterCredentialDescription(Android.Credentials.UnregisterCredentialDescriptionRequest arg0)
        {
            IExecuteWithSignature("unregisterCredentialDescription", "(Landroid/credentials/UnregisterCredentialDescriptionRequest;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}