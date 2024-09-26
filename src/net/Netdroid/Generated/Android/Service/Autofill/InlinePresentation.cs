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

namespace Android.Service.Autofill
{
    #region InlinePresentation declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html"/>
    /// </summary>
    public partial class InlinePresentation : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.autofill.InlinePresentation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InlinePresentation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InlinePresentation(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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

    #region InlinePresentation implementation
    public partial class InlinePresentation
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#%3Cinit%3E(android.app.slice.Slice,android.widget.inline.InlinePresentationSpec,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Slice.Slice"/></param>
        /// <param name="arg1"><see cref="Android.Widget.Inline.InlinePresentationSpec"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public InlinePresentation(Android.App.Slice.Slice arg0, Android.Widget.Inline.InlinePresentationSpec arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#createTooltipPresentation(android.app.slice.Slice,android.widget.inline.InlinePresentationSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Slice.Slice"/></param>
        /// <param name="arg1"><see cref="Android.Widget.Inline.InlinePresentationSpec"/></param>
        /// <returns><see cref="Android.Service.Autofill.InlinePresentation"/></returns>
        public static Android.Service.Autofill.InlinePresentation CreateTooltipPresentation(Android.App.Slice.Slice arg0, Android.Widget.Inline.InlinePresentationSpec arg1)
        {
            return SExecuteWithSignature<Android.Service.Autofill.InlinePresentation>(LocalBridgeClazz, "createTooltipPresentation", "(Landroid/app/slice/Slice;Landroid/widget/inline/InlinePresentationSpec;)Landroid/service/autofill/InlinePresentation;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#getSlice()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Slice.Slice"/></returns>
        public Android.App.Slice.Slice GetSlice()
        {
            return IExecuteWithSignature<Android.App.Slice.Slice>("getSlice", "()Landroid/app/slice/Slice;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#getInlinePresentationSpec()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Inline.InlinePresentationSpec"/></returns>
        public Android.Widget.Inline.InlinePresentationSpec GetInlinePresentationSpec()
        {
            return IExecuteWithSignature<Android.Widget.Inline.InlinePresentationSpec>("getInlinePresentationSpec", "()Landroid/widget/inline/InlinePresentationSpec;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#isPinned()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPinned()
        {
            return IExecuteWithSignature<bool>("isPinned", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/InlinePresentation.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}