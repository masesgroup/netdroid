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

namespace Android.Print
{
    #region PrinterCapabilitiesInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html"/>
    /// </summary>
    public partial class PrinterCapabilitiesInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.print.PrinterCapabilitiesInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrinterCapabilitiesInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrinterCapabilitiesInfo(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.print.PrinterCapabilitiesInfo$Builder";
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

    #region PrinterCapabilitiesInfo implementation
    public partial class PrinterCapabilitiesInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#getDefaults()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrintAttributes"/></returns>
        public Android.Print.PrintAttributes GetDefaults()
        {
            return IExecuteWithSignature<Android.Print.PrintAttributes>("getDefaults", "()Landroid/print/PrintAttributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#getMinMargins()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrintAttributes.Margins"/></returns>
        public Android.Print.PrintAttributes.Margins GetMinMargins()
        {
            return IExecuteWithSignature<Android.Print.PrintAttributes.Margins>("getMinMargins", "()Landroid/print/PrintAttributes$Margins;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#getColorModes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetColorModes()
        {
            return IExecuteWithSignature<int>("getColorModes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#getDuplexModes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDuplexModes()
        {
            return IExecuteWithSignature<int>("getDuplexModes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#getMediaSizes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Print.PrintAttributes.MediaSize> GetMediaSizes()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Print.PrintAttributes.MediaSize>>("getMediaSizes", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#getResolutions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Print.PrintAttributes.Resolution> GetResolutions()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Print.PrintAttributes.Resolution>>("getResolutions", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html#%3Cinit%3E(android.print.PrinterId)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrinterId"/></param>
            public Builder(Android.Print.PrinterId arg0)
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
            /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Print.PrinterCapabilitiesInfo"/></returns>
            public Android.Print.PrinterCapabilitiesInfo Build()
            {
                return IExecuteWithSignature<Android.Print.PrinterCapabilitiesInfo>("build", "()Landroid/print/PrinterCapabilitiesInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html#addMediaSize(android.print.PrintAttributes.MediaSize,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrintAttributes.MediaSize"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Android.Print.PrinterCapabilitiesInfo.Builder"/></returns>
            public Android.Print.PrinterCapabilitiesInfo.Builder AddMediaSize(Android.Print.PrintAttributes.MediaSize arg0, bool arg1)
            {
                return IExecuteWithSignature<Android.Print.PrinterCapabilitiesInfo.Builder>("addMediaSize", "(Landroid/print/PrintAttributes$MediaSize;Z)Landroid/print/PrinterCapabilitiesInfo$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html#addResolution(android.print.PrintAttributes.Resolution,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrintAttributes.Resolution"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Android.Print.PrinterCapabilitiesInfo.Builder"/></returns>
            public Android.Print.PrinterCapabilitiesInfo.Builder AddResolution(Android.Print.PrintAttributes.Resolution arg0, bool arg1)
            {
                return IExecuteWithSignature<Android.Print.PrinterCapabilitiesInfo.Builder>("addResolution", "(Landroid/print/PrintAttributes$Resolution;Z)Landroid/print/PrinterCapabilitiesInfo$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html#setColorModes(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Print.PrinterCapabilitiesInfo.Builder"/></returns>
            public Android.Print.PrinterCapabilitiesInfo.Builder SetColorModes(int arg0, int arg1)
            {
                return IExecuteWithSignature<Android.Print.PrinterCapabilitiesInfo.Builder>("setColorModes", "(II)Landroid/print/PrinterCapabilitiesInfo$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html#setDuplexModes(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Print.PrinterCapabilitiesInfo.Builder"/></returns>
            public Android.Print.PrinterCapabilitiesInfo.Builder SetDuplexModes(int arg0, int arg1)
            {
                return IExecuteWithSignature<Android.Print.PrinterCapabilitiesInfo.Builder>("setDuplexModes", "(II)Landroid/print/PrinterCapabilitiesInfo$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterCapabilitiesInfo.Builder.html#setMinMargins(android.print.PrintAttributes.Margins)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrintAttributes.Margins"/></param>
            /// <returns><see cref="Android.Print.PrinterCapabilitiesInfo.Builder"/></returns>
            public Android.Print.PrinterCapabilitiesInfo.Builder SetMinMargins(Android.Print.PrintAttributes.Margins arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterCapabilitiesInfo.Builder>("setMinMargins", "(Landroid/print/PrintAttributes$Margins;)Landroid/print/PrinterCapabilitiesInfo$Builder;", arg0);
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