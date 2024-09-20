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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os
{
    #region TokenWatcher
    public partial class TokenWatcher
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#%3Cinit%3E(android.os.Handler,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public TokenWatcher(Android.Os.Handler arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#acquired()"/>
        /// </summary>
        public void Acquired()
        {
            IExecuteWithSignature("acquired", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#released()"/>
        /// </summary>
        public void Released()
        {
            IExecuteWithSignature("released", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#isAcquired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAcquired()
        {
            return IExecuteWithSignature<bool>("isAcquired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#acquire(android.os.IBinder,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Acquire(Android.Os.IBinder arg0, Java.Lang.String arg1)
        {
            IExecute("acquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#cleanup(android.os.IBinder,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Cleanup(Android.Os.IBinder arg0, bool arg1)
        {
            IExecute("cleanup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#dump()"/>
        /// </summary>
        public void Dump()
        {
            IExecuteWithSignature("dump", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#dump(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        public void Dump(Java.Io.PrintWriter arg0)
        {
            IExecuteWithSignature("dump", "(Ljava/io/PrintWriter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/TokenWatcher.html#release(android.os.IBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
        public void Release(Android.Os.IBinder arg0)
        {
            IExecuteWithSignature("release", "(Landroid/os/IBinder;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}