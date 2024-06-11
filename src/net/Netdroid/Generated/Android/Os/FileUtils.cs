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

namespace Android.Os
{
    #region FileUtils
    public partial class FileUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileUtils.html#copy(java.io.FileDescriptor,java.io.FileDescriptor,android.os.CancellationSignal,java.util.concurrent.Executor,android.os.FileUtils.ProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Os.FileUtils.ProgressListener"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static long Copy(Java.Io.FileDescriptor arg0, Java.Io.FileDescriptor arg1, Android.Os.CancellationSignal arg2, Java.Util.Concurrent.Executor arg3, Android.Os.FileUtils.ProgressListener arg4)
        {
            return SExecute<long>(LocalBridgeClazz, "copy", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileUtils.html#copy(java.io.FileDescriptor,java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static long Copy(Java.Io.FileDescriptor arg0, Java.Io.FileDescriptor arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "copy", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileUtils.html#copy(java.io.InputStream,java.io.OutputStream,android.os.CancellationSignal,java.util.concurrent.Executor,android.os.FileUtils.ProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Os.FileUtils.ProgressListener"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static long Copy(Java.Io.InputStream arg0, Java.Io.OutputStream arg1, Android.Os.CancellationSignal arg2, Java.Util.Concurrent.Executor arg3, Android.Os.FileUtils.ProgressListener arg4)
        {
            return SExecute<long>(LocalBridgeClazz, "copy", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileUtils.html#copy(java.io.InputStream,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static long Copy(Java.Io.InputStream arg0, Java.Io.OutputStream arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "copy", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileUtils.html#closeQuietly(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        [global::System.Obsolete()]
        public static void CloseQuietly(Java.Io.FileDescriptor arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "closeQuietly", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileUtils.html#closeQuietly(java.lang.AutoCloseable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.AutoCloseable"/></param>
        [global::System.Obsolete()]
        public static void CloseQuietly(Java.Lang.AutoCloseable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "closeQuietly", "(Ljava/lang/AutoCloseable;)V", arg0);
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
                AddEventHandler("onProgress", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(OnProgressEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/os/FileUtils.ProgressListener.html#onProgress(long)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnProgress"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<long> OnOnProgress { get; set; } = null;

            void OnProgressEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
            {
                var methodToExecute = (OnOnProgress != null) ? OnOnProgress : OnProgress;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/FileUtils.ProgressListener.html#onProgress(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public virtual void OnProgress(long arg0)
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
            /// <see href="https://developer.android.com/reference/android/os/FileUtils.ProgressListener.html#onProgress(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public override void OnProgress(long arg0)
            {
                IExecuteWithSignature("onProgress", "(J)V", arg0);
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