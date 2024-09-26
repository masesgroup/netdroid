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

namespace Android.Sax
{
    #region TextElementListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/sax/TextElementListener.html"/>
    /// </summary>
    public partial class TextElementListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextElementListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.android.sax.TextElementListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region TextElementListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="TextElementListener"/> or its generic type if there is one
    /// </summary>
    public partial class TextElementListenerDirect : TextElementListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "android.sax.TextElementListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region ITextElementListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.sax.TextElementListener implementing <see href="https://developer.android.com/reference/android/sax/TextElementListener.html"/>
    /// </summary>
    public partial interface ITextElementListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TextElementListener implementation
    public partial class TextElementListener : Android.Sax.ITextElementListener, Android.Sax.IStartElementListener, Android.Sax.IEndTextElementListener
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
        /// Handlers initializer for <see cref="TextElementListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("end", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(EndEventHandler));
            AddEventHandler("start", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(StartEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/sax/EndTextElementListener.html#end(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String> OnEnd { get; set; } = null;

        bool hasOverrideEnd = true;
        void EndEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideEnd = true;
            var methodToExecute = (OnEnd != null) ? OnEnd : End;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideEnd;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/EndTextElementListener.html#end(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public virtual void End(Java.Lang.String arg0)
        {
            hasOverrideEnd = false;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/sax/StartElementListener.html#start(org.xml.sax.Attributes)"/>
        /// </summary>
        /// <remarks>If <see cref="OnStart"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Xml.Sax.Attributes> OnStart { get; set; } = null;

        bool hasOverrideStart = true;
        void StartEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideStart = true;
            var methodToExecute = (OnStart != null) ? OnStart : Start;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Xml.Sax.Attributes>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideStart;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/StartElementListener.html#start(org.xml.sax.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Attributes"/></param>
        public virtual void Start(Org.Xml.Sax.Attributes arg0)
        {
            hasOverrideStart = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TextElementListenerDirect implementation
    public partial class TextElementListenerDirect : Android.Sax.ITextElementListener, Android.Sax.IStartElementListener, Android.Sax.IEndTextElementListener
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
            IExecute("end", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/StartElementListener.html#start(org.xml.sax.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Attributes"/></param>
        public override void Start(Org.Xml.Sax.Attributes arg0)
        {
            IExecute("start", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}