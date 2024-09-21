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
    #region Dataset declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.html"/>
    /// </summary>
    public partial class Dataset : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.autofill.Dataset";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Dataset() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Dataset(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.service.autofill.Dataset$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region Dataset implementation
    public partial class Dataset
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#%3Cinit%3E(android.service.autofill.Presentations)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.Presentations"/></param>
            public Builder(Android.Service.Autofill.Presentations arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#%3Cinit%3E(android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RemoteViews"/></param>
            [global::System.Obsolete()]
            public Builder(Android.Widget.RemoteViews arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Autofill.Dataset"/></returns>
            public Android.Service.Autofill.Dataset Build()
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset>("build", "()Landroid/service/autofill/Dataset;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setAuthentication(android.content.IntentSender)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.IntentSender"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetAuthentication(Android.Content.IntentSender arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset.Builder>("setAuthentication", "(Landroid/content/IntentSender;)Landroid/service/autofill/Dataset$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setField(android.view.autofill.AutofillId,android.service.autofill.Field)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.Service.Autofill.Field"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetField(Android.View.Autofill.AutofillId arg0, Android.Service.Autofill.Field arg1)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setField", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setField(java.lang.String,android.service.autofill.Field)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Service.Autofill.Field"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetField(Java.Lang.String arg0, Android.Service.Autofill.Field arg1)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setField", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setFieldForAllHints(android.service.autofill.Field)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.Field"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetFieldForAllHints(Android.Service.Autofill.Field arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset.Builder>("setFieldForAllHints", "(Landroid/service/autofill/Field;)Landroid/service/autofill/Dataset$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            public Android.Service.Autofill.Dataset.Builder SetId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset.Builder>("setId", "(Ljava/lang/String;)Landroid/service/autofill/Dataset$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setInlinePresentation(android.service.autofill.InlinePresentation,android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <param name="arg1"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetInlinePresentation(Android.Service.Autofill.InlinePresentation arg0, Android.Service.Autofill.InlinePresentation arg1)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setInlinePresentation", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setInlinePresentation(android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetInlinePresentation(Android.Service.Autofill.InlinePresentation arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Dataset.Builder>("setInlinePresentation", "(Landroid/service/autofill/InlinePresentation;)Landroid/service/autofill/Dataset$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue,android.widget.RemoteViews,android.service.autofill.InlinePresentation,android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <param name="arg2"><see cref="Android.Widget.RemoteViews"/></param>
            /// <param name="arg3"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <param name="arg4"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1, Android.Widget.RemoteViews arg2, Android.Service.Autofill.InlinePresentation arg3, Android.Service.Autofill.InlinePresentation arg4)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue,android.widget.RemoteViews,android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <param name="arg2"><see cref="Android.Widget.RemoteViews"/></param>
            /// <param name="arg3"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1, Android.Widget.RemoteViews arg2, Android.Service.Autofill.InlinePresentation arg3)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue,android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <param name="arg2"><see cref="Android.Widget.RemoteViews"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1, Android.Widget.RemoteViews arg2)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue,java.util.regex.Pattern,android.widget.RemoteViews,android.service.autofill.InlinePresentation,android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <param name="arg2"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <param name="arg3"><see cref="Android.Widget.RemoteViews"/></param>
            /// <param name="arg4"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <param name="arg5"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1, Java.Util.Regex.Pattern arg2, Android.Widget.RemoteViews arg3, Android.Service.Autofill.InlinePresentation arg4, Android.Service.Autofill.InlinePresentation arg5)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue,java.util.regex.Pattern,android.widget.RemoteViews,android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <param name="arg2"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <param name="arg3"><see cref="Android.Widget.RemoteViews"/></param>
            /// <param name="arg4"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1, Java.Util.Regex.Pattern arg2, Android.Widget.RemoteViews arg3, Android.Service.Autofill.InlinePresentation arg4)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue,java.util.regex.Pattern,android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <param name="arg2"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <param name="arg3"><see cref="Android.Widget.RemoteViews"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1, Java.Util.Regex.Pattern arg2, Android.Widget.RemoteViews arg3)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue,java.util.regex.Pattern)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <param name="arg2"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1, Java.Util.Regex.Pattern arg2)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Dataset.Builder.html#setValue(android.view.autofill.AutofillId,android.view.autofill.AutofillValue)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Android.View.Autofill.AutofillValue"/></param>
            /// <returns><see cref="Android.Service.Autofill.Dataset.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.Dataset.Builder SetValue(Android.View.Autofill.AutofillId arg0, Android.View.Autofill.AutofillValue arg1)
            {
                return IExecute<Android.Service.Autofill.Dataset.Builder>("setValue", arg0, arg1);
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