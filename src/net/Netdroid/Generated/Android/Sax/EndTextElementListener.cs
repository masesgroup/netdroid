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

namespace Android.Sax
{
    #region IEndTextElementListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.sax.EndTextElementListener implementing <see href="https://developer.android.com/reference/android/sax/EndTextElementListener.html"/>
    /// </summary>
    public partial interface IEndTextElementListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EndTextElementListener
    public partial class EndTextElementListener : Android.Sax.IEndTextElementListener
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
        /// Handlers initializer for <see cref="EndTextElementListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("end", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(EndEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/sax/EndTextElementListener.html#end(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String> OnEnd { get; set; } = null;

        void EndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnEnd != null) ? OnEnd : End;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/EndTextElementListener.html#end(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public virtual void End(Java.Lang.String arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EndTextElementListenerDirect
    public partial class EndTextElementListenerDirect : Android.Sax.IEndTextElementListener
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
        /// <see href="https://developer.android.com/reference/android/sax/EndTextElementListener.html#end(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public override void End(Java.Lang.String arg0)
        {
            IExecuteWithSignature("end", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}