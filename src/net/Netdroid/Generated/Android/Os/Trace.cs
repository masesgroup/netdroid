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

namespace Android.Os
{
    #region Trace
    public partial class Trace
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Trace.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Trace.html#beginAsyncSection(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void BeginAsyncSection(Java.Lang.String arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "beginAsyncSection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Trace.html#beginSection(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void BeginSection(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "beginSection", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Trace.html#endAsyncSection(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void EndAsyncSection(Java.Lang.String arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "endAsyncSection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Trace.html#endSection()"/>
        /// </summary>
        public static void EndSection()
        {
            SExecuteWithSignature(LocalBridgeClazz, "endSection", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Trace.html#setCounter(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public static void SetCounter(Java.Lang.String arg0, long arg1)
        {
            SExecute(LocalBridgeClazz, "setCounter", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}