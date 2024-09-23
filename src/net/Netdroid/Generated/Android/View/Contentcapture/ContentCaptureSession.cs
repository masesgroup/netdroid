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

namespace Android.View.Contentcapture
{
    #region ContentCaptureSession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html"/>
    /// </summary>
    public partial class ContentCaptureSession : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.view.contentcapture.ContentCaptureSession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ContentCaptureSession class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ContentCaptureSession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ContentCaptureSession class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ContentCaptureSession(params object[] args) : base(args) { }
    
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

    #region ContentCaptureSession implementation
    public partial class ContentCaptureSession
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
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#newAutofillId(android.view.autofill.AutofillId,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Android.View.Autofill.AutofillId"/></returns>
        public Android.View.Autofill.AutofillId NewAutofillId(Android.View.Autofill.AutofillId arg0, long arg1)
        {
            return IExecute<Android.View.Autofill.AutofillId>("newAutofillId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#getContentCaptureContext()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Contentcapture.ContentCaptureContext"/></returns>
        public Android.View.Contentcapture.ContentCaptureContext GetContentCaptureContext()
        {
            return IExecuteWithSignature<Android.View.Contentcapture.ContentCaptureContext>("getContentCaptureContext", "()Landroid/view/contentcapture/ContentCaptureContext;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#createContentCaptureSession(android.view.contentcapture.ContentCaptureContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Contentcapture.ContentCaptureContext"/></param>
        /// <returns><see cref="Android.View.Contentcapture.ContentCaptureSession"/></returns>
        public Android.View.Contentcapture.ContentCaptureSession CreateContentCaptureSession(Android.View.Contentcapture.ContentCaptureContext arg0)
        {
            return IExecuteWithSignature<Android.View.Contentcapture.ContentCaptureSession>("createContentCaptureSession", "(Landroid/view/contentcapture/ContentCaptureContext;)Landroid/view/contentcapture/ContentCaptureSession;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#getContentCaptureSessionId()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Contentcapture.ContentCaptureSessionId"/></returns>
        public Android.View.Contentcapture.ContentCaptureSessionId GetContentCaptureSessionId()
        {
            return IExecuteWithSignature<Android.View.Contentcapture.ContentCaptureSessionId>("getContentCaptureSessionId", "()Landroid/view/contentcapture/ContentCaptureSessionId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#newViewStructure(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.View.ViewStructure"/></returns>
        public Android.View.ViewStructure NewViewStructure(Android.View.View arg0)
        {
            return IExecuteWithSignature<Android.View.ViewStructure>("newViewStructure", "(Landroid/view/View;)Landroid/view/ViewStructure;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#newVirtualViewStructure(android.view.autofill.AutofillId,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Android.View.ViewStructure"/></returns>
        public Android.View.ViewStructure NewVirtualViewStructure(Android.View.Autofill.AutofillId arg0, long arg1)
        {
            return IExecute<Android.View.ViewStructure>("newVirtualViewStructure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifySessionPaused()"/>
        /// </summary>
        public void NotifySessionPaused()
        {
            IExecuteWithSignature("notifySessionPaused", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifySessionResumed()"/>
        /// </summary>
        public void NotifySessionResumed()
        {
            IExecuteWithSignature("notifySessionResumed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifyViewAppeared(android.view.ViewStructure)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewStructure"/></param>
        public void NotifyViewAppeared(Android.View.ViewStructure arg0)
        {
            IExecuteWithSignature("notifyViewAppeared", "(Landroid/view/ViewStructure;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifyViewDisappeared(android.view.autofill.AutofillId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
        public void NotifyViewDisappeared(Android.View.Autofill.AutofillId arg0)
        {
            IExecuteWithSignature("notifyViewDisappeared", "(Landroid/view/autofill/AutofillId;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifyViewInsetsChanged(android.graphics.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Insets"/></param>
        public void NotifyViewInsetsChanged(Android.Graphics.Insets arg0)
        {
            IExecuteWithSignature("notifyViewInsetsChanged", "(Landroid/graphics/Insets;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifyViewsAppeared(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void NotifyViewsAppeared(Java.Util.List<Android.View.ViewStructure> arg0)
        {
            IExecuteWithSignature("notifyViewsAppeared", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifyViewsDisappeared(android.view.autofill.AutofillId,long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void NotifyViewsDisappeared(Android.View.Autofill.AutofillId arg0, long[] arg1)
        {
            IExecute("notifyViewsDisappeared", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#notifyViewTextChanged(android.view.autofill.AutofillId,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        public void NotifyViewTextChanged(Android.View.Autofill.AutofillId arg0, Java.Lang.CharSequence arg1)
        {
            IExecute("notifyViewTextChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#setContentCaptureContext(android.view.contentcapture.ContentCaptureContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Contentcapture.ContentCaptureContext"/></param>
        public void SetContentCaptureContext(Android.View.Contentcapture.ContentCaptureContext arg0)
        {
            IExecuteWithSignature("setContentCaptureContext", "(Landroid/view/contentcapture/ContentCaptureContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}