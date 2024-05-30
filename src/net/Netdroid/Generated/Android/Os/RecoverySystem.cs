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

namespace Android.Os
{
    #region RecoverySystem
    public partial class RecoverySystem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RecoverySystem.html#installPackage(android.content.Context,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void InstallPackage(Android.Content.Context arg0, Java.Io.File arg1)
        {
            SExecute(LocalBridgeClazz, "installPackage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RecoverySystem.html#rebootWipeCache(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void RebootWipeCache(Android.Content.Context arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "rebootWipeCache", "(Landroid/content/Context;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RecoverySystem.html#rebootWipeUserData(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void RebootWipeUserData(Android.Content.Context arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "rebootWipeUserData", "(Landroid/content/Context;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RecoverySystem.html#verifyPackage(java.io.File,android.os.RecoverySystem.ProgressListener,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Android.Os.RecoverySystem.ProgressListener"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Security.GeneralSecurityException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static void VerifyPackage(Java.Io.File arg0, Android.Os.RecoverySystem.ProgressListener arg1, Java.Io.File arg2)
        {
            SExecute(LocalBridgeClazz, "verifyPackage", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region ProgressListener
        public partial class ProgressListener
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
            /// Handlers initializer for <see cref="ProgressListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onProgress", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnProgressEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/os/RecoverySystem.ProgressListener.html#onProgress(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnProgress"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<int> OnOnProgress { get; set; } = null;

            void OnProgressEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnProgress != null) ? OnOnProgress : OnProgress;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/RecoverySystem.ProgressListener.html#onProgress(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnProgress(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ProgressListenerDirect
        public partial class ProgressListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/os/RecoverySystem.ProgressListener.html#onProgress(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnProgress(int arg0)
            {
                IExecuteWithSignature("onProgress", "(I)V", arg0);
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