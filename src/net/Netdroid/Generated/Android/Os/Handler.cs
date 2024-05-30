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
    #region Handler
    public partial class Handler
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#%3Cinit%3E(android.os.Looper,android.os.Handler.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Looper"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler.Callback"/></param>
        public Handler(Android.Os.Looper arg0, Android.Os.Handler.Callback arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#%3Cinit%3E(android.os.Looper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Looper"/></param>
        public Handler(Android.Os.Looper arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#createAsync(android.os.Looper,android.os.Handler.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Looper"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler.Callback"/></param>
        /// <returns><see cref="Android.Os.Handler"/></returns>
        public static Android.Os.Handler CreateAsync(Android.Os.Looper arg0, Android.Os.Handler.Callback arg1)
        {
            return SExecute<Android.Os.Handler>(LocalBridgeClazz, "createAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#createAsync(android.os.Looper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Looper"/></param>
        /// <returns><see cref="Android.Os.Handler"/></returns>
        public static Android.Os.Handler CreateAsync(Android.Os.Looper arg0)
        {
            return SExecuteWithSignature<Android.Os.Handler>(LocalBridgeClazz, "createAsync", "(Landroid/os/Looper;)Landroid/os/Handler;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#getLooper()"/> 
        /// </summary>
        public Android.Os.Looper Looper
        {
            get { return IExecuteWithSignature<Android.Os.Looper>("getLooper", "()Landroid/os/Looper;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#sendMessageAtTime(android.os.Message,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendMessageAtTime(Android.Os.Message arg0, long arg1)
        {
            return IExecute<bool>("sendMessageAtTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#obtainMessage()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public Android.Os.Message ObtainMessage()
        {
            return IExecuteWithSignature<Android.Os.Message>("obtainMessage", "()Landroid/os/Message;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#obtainMessage(int,int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public Android.Os.Message ObtainMessage(int arg0, int arg1, int arg2, object arg3)
        {
            return IExecute<Android.Os.Message>("obtainMessage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#obtainMessage(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public Android.Os.Message ObtainMessage(int arg0, int arg1, int arg2)
        {
            return IExecute<Android.Os.Message>("obtainMessage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#obtainMessage(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public Android.Os.Message ObtainMessage(int arg0, object arg1)
        {
            return IExecute<Android.Os.Message>("obtainMessage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#obtainMessage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public Android.Os.Message ObtainMessage(int arg0)
        {
            return IExecuteWithSignature<Android.Os.Message>("obtainMessage", "(I)Landroid/os/Message;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#hasCallbacks(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCallbacks(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<bool>("hasCallbacks", "(Ljava/lang/Runnable;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#hasMessages(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasMessages(int arg0, object arg1)
        {
            return IExecute<bool>("hasMessages", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#hasMessages(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasMessages(int arg0)
        {
            return IExecuteWithSignature<bool>("hasMessages", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#post(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Post(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<bool>("post", "(Ljava/lang/Runnable;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#postAtFrontOfQueue(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostAtFrontOfQueue(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<bool>("postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#postAtTime(java.lang.Runnable,java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostAtTime(Java.Lang.Runnable arg0, object arg1, long arg2)
        {
            return IExecute<bool>("postAtTime", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#postAtTime(java.lang.Runnable,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostAtTime(Java.Lang.Runnable arg0, long arg1)
        {
            return IExecute<bool>("postAtTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#postDelayed(java.lang.Runnable,java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostDelayed(Java.Lang.Runnable arg0, object arg1, long arg2)
        {
            return IExecute<bool>("postDelayed", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#postDelayed(java.lang.Runnable,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostDelayed(Java.Lang.Runnable arg0, long arg1)
        {
            return IExecute<bool>("postDelayed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#sendEmptyMessage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendEmptyMessage(int arg0)
        {
            return IExecuteWithSignature<bool>("sendEmptyMessage", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#sendEmptyMessageAtTime(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendEmptyMessageAtTime(int arg0, long arg1)
        {
            return IExecute<bool>("sendEmptyMessageAtTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#sendEmptyMessageDelayed(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendEmptyMessageDelayed(int arg0, long arg1)
        {
            return IExecute<bool>("sendEmptyMessageDelayed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#sendMessage(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendMessage(Android.Os.Message arg0)
        {
            return IExecuteWithSignature<bool>("sendMessage", "(Landroid/os/Message;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#sendMessageAtFrontOfQueue(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendMessageAtFrontOfQueue(Android.Os.Message arg0)
        {
            return IExecuteWithSignature<bool>("sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#sendMessageDelayed(android.os.Message,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendMessageDelayed(Android.Os.Message arg0, long arg1)
        {
            return IExecute<bool>("sendMessageDelayed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecute("dump", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#removeCallbacks(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void RemoveCallbacks(Java.Lang.Runnable arg0, object arg1)
        {
            IExecute("removeCallbacks", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#removeCallbacks(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void RemoveCallbacks(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("removeCallbacks", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#removeCallbacksAndMessages(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveCallbacksAndMessages(object arg0)
        {
            IExecuteWithSignature("removeCallbacksAndMessages", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#removeMessages(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void RemoveMessages(int arg0, object arg1)
        {
            IExecute("removeMessages", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#removeMessages(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveMessages(int arg0)
        {
            IExecuteWithSignature("removeMessages", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#getMessageName(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMessageName(Android.Os.Message arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getMessageName", "(Landroid/os/Message;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#dispatchMessage(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        public void DispatchMessage(Android.Os.Message arg0)
        {
            IExecuteWithSignature("dispatchMessage", "(Landroid/os/Message;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Handler.html#handleMessage(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        public void HandleMessage(Android.Os.Message arg0)
        {
            IExecuteWithSignature("handleMessage", "(Landroid/os/Message;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/os/Handler.Callback.html#handleMessage(android.os.Message)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Message"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool HandleMessage(Android.Os.Message arg0)
            {
                return IExecuteWithSignature<bool>("handleMessage", "(Landroid/os/Message;)Z", arg0);
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