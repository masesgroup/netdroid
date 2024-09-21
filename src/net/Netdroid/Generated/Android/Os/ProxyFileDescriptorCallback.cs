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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os
{
    #region ProxyFileDescriptorCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/ProxyFileDescriptorCallback.html"/>
    /// </summary>
    public partial class ProxyFileDescriptorCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ProxyFileDescriptorCallback>
    {
        const string _bridgeClassName = "android.os.ProxyFileDescriptorCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ProxyFileDescriptorCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProxyFileDescriptorCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ProxyFileDescriptorCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProxyFileDescriptorCallback(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ProxyFileDescriptorCallback implementation
    public partial class ProxyFileDescriptorCallback
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
        /// <see href="https://developer.android.com/reference/android/os/ProxyFileDescriptorCallback.html#onRelease()"/>
        /// </summary>
        public void OnRelease()
        {
            IExecuteWithSignature("onRelease", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProxyFileDescriptorCallback.html#onRead(long,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.System.ErrnoException"/>
        public int OnRead(long arg0, int arg1, byte[] arg2)
        {
            return IExecute<int>("onRead", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProxyFileDescriptorCallback.html#onWrite(long,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.System.ErrnoException"/>
        public int OnWrite(long arg0, int arg1, byte[] arg2)
        {
            return IExecute<int>("onWrite", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProxyFileDescriptorCallback.html#onGetSize()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Android.System.ErrnoException"/>
        public long OnGetSize()
        {
            return IExecuteWithSignature<long>("onGetSize", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProxyFileDescriptorCallback.html#onFsync()"/>
        /// </summary>
        /// <exception cref="Android.System.ErrnoException"/>
        public void OnFsync()
        {
            IExecuteWithSignature("onFsync", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}