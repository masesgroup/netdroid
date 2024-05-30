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

namespace Android.Content
{
    #region BroadcastReceiver
    public partial class BroadcastReceiver
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
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#getDebugUnregister()"/> <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#setDebugUnregister(boolean)"/>
        /// </summary>
        public bool DebugUnregister
        {
            get { return IExecuteWithSignature<bool>("getDebugUnregister", "()Z"); } set { IExecuteWithSignature("setDebugUnregister", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#getResultCode()"/> <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#setResultCode(int)"/>
        /// </summary>
        public int ResultCode
        {
            get { return IExecuteWithSignature<int>("getResultCode", "()I"); } set { IExecuteWithSignature("setResultCode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#getResultData()"/> <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#setResultData(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ResultData
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getResultData", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setResultData", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#getSentFromPackage()"/> 
        /// </summary>
        public Java.Lang.String SentFromPackage
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSentFromPackage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#getSentFromUid()"/> 
        /// </summary>
        public int SentFromUid
        {
            get { return IExecuteWithSignature<int>("getSentFromUid", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#onReceive(android.content.Context,android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        public void OnReceive(Android.Content.Context arg0, Android.Content.Intent arg1)
        {
            IExecute("onReceive", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#peekService(android.content.Context,android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Os.IBinder"/></returns>
        public Android.Os.IBinder PeekService(Android.Content.Context arg0, Android.Content.Intent arg1)
        {
            return IExecute<Android.Os.IBinder>("peekService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#goAsync()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.BroadcastReceiver.PendingResult"/></returns>
        public Android.Content.BroadcastReceiver.PendingResult GoAsync()
        {
            return IExecuteWithSignature<Android.Content.BroadcastReceiver.PendingResult>("goAsync", "()Landroid/content/BroadcastReceiver$PendingResult;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#getResultExtras(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetResultExtras(bool arg0)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getResultExtras", "(Z)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#getAbortBroadcast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAbortBroadcast()
        {
            return IExecuteWithSignature<bool>("getAbortBroadcast", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#isInitialStickyBroadcast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInitialStickyBroadcast()
        {
            return IExecuteWithSignature<bool>("isInitialStickyBroadcast", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#isOrderedBroadcast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOrderedBroadcast()
        {
            return IExecuteWithSignature<bool>("isOrderedBroadcast", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#abortBroadcast()"/>
        /// </summary>
        public void AbortBroadcast()
        {
            IExecuteWithSignature("abortBroadcast", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#clearAbortBroadcast()"/>
        /// </summary>
        public void ClearAbortBroadcast()
        {
            IExecuteWithSignature("clearAbortBroadcast", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#setOrderedHint(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOrderedHint(bool arg0)
        {
            IExecuteWithSignature("setOrderedHint", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#setResult(int,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        public void SetResult(int arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
        {
            IExecute("setResult", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.html#setResultExtras(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void SetResultExtras(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("setResultExtras", "(Landroid/os/Bundle;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region PendingResult
        public partial class PendingResult
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
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#getResultCode()"/> <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#setResultCode(int)"/>
            /// </summary>
            public int ResultCode
            {
                get { return IExecuteWithSignature<int>("getResultCode", "()I"); } set { IExecuteWithSignature("setResultCode", "(I)V", value); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#getResultData()"/> <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#setResultData(java.lang.String)"/>
            /// </summary>
            public Java.Lang.String ResultData
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getResultData", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setResultData", "(Ljava/lang/String;)V", value); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#getResultExtras(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetResultExtras(bool arg0)
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getResultExtras", "(Z)Landroid/os/Bundle;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#getAbortBroadcast()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetAbortBroadcast()
            {
                return IExecuteWithSignature<bool>("getAbortBroadcast", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#abortBroadcast()"/>
            /// </summary>
            public void AbortBroadcast()
            {
                IExecuteWithSignature("abortBroadcast", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#clearAbortBroadcast()"/>
            /// </summary>
            public void ClearAbortBroadcast()
            {
                IExecuteWithSignature("clearAbortBroadcast", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#finish()"/>
            /// </summary>
            public void Finish()
            {
                IExecuteWithSignature("finish", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#setResult(int,java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            public void SetResult(int arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
            {
                IExecute("setResult", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/BroadcastReceiver.PendingResult.html#setResultExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            public void SetResultExtras(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("setResultExtras", "(Landroid/os/Bundle;)V", arg0);
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