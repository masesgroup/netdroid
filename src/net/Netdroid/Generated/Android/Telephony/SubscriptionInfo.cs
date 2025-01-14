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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony
{
    #region SubscriptionInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html"/>
    /// </summary>
    public partial class SubscriptionInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.telephony.SubscriptionInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SubscriptionInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SubscriptionInfo(params object[] args) : base(args) { }
    
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

    #region SubscriptionInfo implementation
    public partial class SubscriptionInfo
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#createIconBitmap(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap CreateIconBitmap(Android.Content.Context arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("createIconBitmap", "(Landroid/content/Context;)Landroid/graphics/Bitmap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getGroupUuid()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetGroupUuid()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getGroupUuid", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#isEmbedded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmbedded()
        {
            return IExecuteWithSignature<bool>("isEmbedded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#isOnlyNonTerrestrialNetwork()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOnlyNonTerrestrialNetwork()
        {
            return IExecuteWithSignature<bool>("isOnlyNonTerrestrialNetwork", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#isOpportunistic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpportunistic()
        {
            return IExecuteWithSignature<bool>("isOpportunistic", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getCardId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCardId()
        {
            return IExecuteWithSignature<int>("getCardId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getCarrierId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCarrierId()
        {
            return IExecuteWithSignature<int>("getCarrierId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getDataRoaming()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDataRoaming()
        {
            return IExecuteWithSignature<int>("getDataRoaming", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getIconTint()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIconTint()
        {
            return IExecuteWithSignature<int>("getIconTint", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getMcc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMcc()
        {
            return IExecuteWithSignature<int>("getMcc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getMnc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMnc()
        {
            return IExecuteWithSignature<int>("getMnc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getPortIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPortIndex()
        {
            return IExecuteWithSignature<int>("getPortIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getSimSlotIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSimSlotIndex()
        {
            return IExecuteWithSignature<int>("getSimSlotIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getSubscriptionId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubscriptionId()
        {
            return IExecuteWithSignature<int>("getSubscriptionId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getSubscriptionType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubscriptionType()
        {
            return IExecuteWithSignature<int>("getSubscriptionType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getUsageSetting()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUsageSetting()
        {
            return IExecuteWithSignature<int>("getUsageSetting", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getCarrierName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetCarrierName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCarrierName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getDisplayName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetDisplayName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getDisplayName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getCountryIso()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCountryIso()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCountryIso", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getIccId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetIccId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getIccId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getMccString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMccString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMccString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getMncString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMncString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMncString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetNumber()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNumber", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#getServiceCapabilities()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetServiceCapabilities()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getServiceCapabilities", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SubscriptionInfo.html#writeToParcel(android.os.Parcel,int)"/>
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