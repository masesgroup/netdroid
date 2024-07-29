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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Sip
{
    #region ISipRegistrationListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.net.sip.SipRegistrationListener implementing <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html"/>
    /// </summary>
    public partial interface ISipRegistrationListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SipRegistrationListener
    public partial class SipRegistrationListener : Android.Net.Sip.ISipRegistrationListener
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
        /// Handlers initializer for <see cref="SipRegistrationListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onRegistering", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnRegisteringEventHandler));
            AddEventHandler("onRegistrationDone", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnRegistrationDoneEventHandler));
            AddEventHandler("onRegistrationFailed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnRegistrationFailedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistering(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRegistering"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String> OnOnRegistering { get; set; } = null;

        void OnRegisteringEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnOnRegistering != null) ? OnOnRegistering : OnRegistering;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistering(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public virtual void OnRegistering(Java.Lang.String arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistrationDone(java.lang.String,long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRegistrationDone"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String, long> OnOnRegistrationDone { get; set; } = null;

        void OnRegistrationDoneEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnOnRegistrationDone != null) ? OnOnRegistrationDone : OnRegistrationDone;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<long>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistrationDone(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        [global::System.Obsolete()]
        public virtual void OnRegistrationDone(Java.Lang.String arg0, long arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistrationFailed(java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRegistrationFailed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String, int, Java.Lang.String> OnOnRegistrationFailed { get; set; } = null;

        void OnRegistrationFailedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnOnRegistrationFailed != null) ? OnOnRegistrationFailed : OnRegistrationFailed;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<Java.Lang.String>(1));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistrationFailed(java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public virtual void OnRegistrationFailed(Java.Lang.String arg0, int arg1, Java.Lang.String arg2)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SipRegistrationListenerDirect
    public partial class SipRegistrationListenerDirect : Android.Net.Sip.ISipRegistrationListener
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
        /// <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistering(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public override void OnRegistering(Java.Lang.String arg0)
        {
            IExecuteWithSignature("onRegistering", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistrationDone(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        [global::System.Obsolete()]
        public override void OnRegistrationDone(Java.Lang.String arg0, long arg1)
        {
            IExecute("onRegistrationDone", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipRegistrationListener.html#onRegistrationFailed(java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public override void OnRegistrationFailed(Java.Lang.String arg0, int arg1, Java.Lang.String arg2)
        {
            IExecute("onRegistrationFailed", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}