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

namespace Android.Location
{
    #region IOnNmeaMessageListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.location.OnNmeaMessageListener implementing <see href="https://developer.android.com/reference/android/location/OnNmeaMessageListener.html"/>
    /// </summary>
    public partial interface IOnNmeaMessageListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OnNmeaMessageListener
    public partial class OnNmeaMessageListener : Android.Location.IOnNmeaMessageListener
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
        /// Handlers initializer for <see cref="OnNmeaMessageListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onNmeaMessage", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnNmeaMessageEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/location/OnNmeaMessageListener.html#onNmeaMessage(java.lang.String,long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnNmeaMessage"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String, long> OnOnNmeaMessage { get; set; } = null;

        void OnNmeaMessageEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnOnNmeaMessage != null) ? OnOnNmeaMessage : OnNmeaMessage;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<long>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/OnNmeaMessageListener.html#onNmeaMessage(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public virtual void OnNmeaMessage(Java.Lang.String arg0, long arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OnNmeaMessageListenerDirect
    public partial class OnNmeaMessageListenerDirect : Android.Location.IOnNmeaMessageListener
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
        /// <see href="https://developer.android.com/reference/android/location/OnNmeaMessageListener.html#onNmeaMessage(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public override void OnNmeaMessage(Java.Lang.String arg0, long arg1)
        {
            IExecute("onNmeaMessage", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}