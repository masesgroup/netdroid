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
    #region RemoteCallbackList
    public partial class RemoteCallbackList
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
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getRegisteredCallbackCount()"/> 
        /// </summary>
        public int RegisteredCallbackCount
        {
            get { return IExecuteWithSignature<int>("getRegisteredCallbackCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#register(android.os.IInterface,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IInterface"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Register(Android.Os.IInterface arg0, object arg1)
        {
            return IExecute<bool>("register", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#register(android.os.IInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IInterface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Register(Android.Os.IInterface arg0)
        {
            return IExecuteWithSignature<bool>("register", "(Landroid/os/IInterface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#unregister(android.os.IInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IInterface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Unregister(Android.Os.IInterface arg0)
        {
            return IExecuteWithSignature<bool>("unregister", "(Landroid/os/IInterface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getBroadcastItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.IInterface"/></returns>
        public Android.Os.IInterface GetBroadcastItem(int arg0)
        {
            return IExecuteWithSignature<Android.Os.IInterface>("getBroadcastItem", "(I)Landroid/os/IInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getRegisteredCallbackItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.IInterface"/></returns>
        public Android.Os.IInterface GetRegisteredCallbackItem(int arg0)
        {
            return IExecuteWithSignature<Android.Os.IInterface>("getRegisteredCallbackItem", "(I)Landroid/os/IInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#beginBroadcast()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BeginBroadcast()
        {
            return IExecuteWithSignature<int>("beginBroadcast", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getBroadcastCookie(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetBroadcastCookie(int arg0)
        {
            return IExecuteWithSignature("getBroadcastCookie", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getRegisteredCallbackCookie(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetRegisteredCallbackCookie(int arg0)
        {
            return IExecuteWithSignature("getRegisteredCallbackCookie", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#finishBroadcast()"/>
        /// </summary>
        public void FinishBroadcast()
        {
            IExecuteWithSignature("finishBroadcast", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#kill()"/>
        /// </summary>
        public void Kill()
        {
            IExecuteWithSignature("kill", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#onCallbackDied(android.os.IInterface,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IInterface"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void OnCallbackDied(Android.Os.IInterface arg0, object arg1)
        {
            IExecute("onCallbackDied", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#onCallbackDied(android.os.IInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IInterface"/></param>
        public void OnCallbackDied(Android.Os.IInterface arg0)
        {
            IExecuteWithSignature("onCallbackDied", "(Landroid/os/IInterface;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RemoteCallbackList<E>
    public partial class RemoteCallbackList<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Os.RemoteCallbackList{E}"/> to <see cref="Android.Os.RemoteCallbackList"/>
        /// </summary>
        public static implicit operator Android.Os.RemoteCallbackList(Android.Os.RemoteCallbackList<E> t) => t.Cast<Android.Os.RemoteCallbackList>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getRegisteredCallbackCount()"/> 
        /// </summary>
        public int RegisteredCallbackCount
        {
            get { return IExecuteWithSignature<int>("getRegisteredCallbackCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#register(android.os.IInterface,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Register(E arg0, object arg1)
        {
            return IExecute<bool>("register", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#register(android.os.IInterface)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Register(E arg0)
        {
            return IExecuteWithSignature<bool>("register", "(Landroid/os/IInterface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#unregister(android.os.IInterface)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Unregister(E arg0)
        {
            return IExecuteWithSignature<bool>("unregister", "(Landroid/os/IInterface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getBroadcastItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetBroadcastItem(int arg0)
        {
            return IExecuteWithSignature<E>("getBroadcastItem", "(I)Landroid/os/IInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getRegisteredCallbackItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetRegisteredCallbackItem(int arg0)
        {
            return IExecuteWithSignature<E>("getRegisteredCallbackItem", "(I)Landroid/os/IInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#beginBroadcast()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BeginBroadcast()
        {
            return IExecuteWithSignature<int>("beginBroadcast", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getBroadcastCookie(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetBroadcastCookie(int arg0)
        {
            return IExecuteWithSignature("getBroadcastCookie", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#getRegisteredCallbackCookie(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetRegisteredCallbackCookie(int arg0)
        {
            return IExecuteWithSignature("getRegisteredCallbackCookie", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#finishBroadcast()"/>
        /// </summary>
        public void FinishBroadcast()
        {
            IExecuteWithSignature("finishBroadcast", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#kill()"/>
        /// </summary>
        public void Kill()
        {
            IExecuteWithSignature("kill", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#onCallbackDied(android.os.IInterface,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void OnCallbackDied(E arg0, object arg1)
        {
            IExecute("onCallbackDied", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/RemoteCallbackList.html#onCallbackDied(android.os.IInterface)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void OnCallbackDied(E arg0)
        {
            IExecuteWithSignature("onCallbackDied", "(Landroid/os/IInterface;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}