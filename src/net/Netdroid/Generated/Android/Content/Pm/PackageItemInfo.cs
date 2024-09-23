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

namespace Android.Content.Pm
{
    #region PackageItemInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html"/>
    /// </summary>
    public partial class PackageItemInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PackageItemInfo>
    {
        const string _bridgeClassName = "android.content.pm.PackageItemInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PackageItemInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PackageItemInfo(params object[] args) : base(args) { }
    
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

    #region PackageItemInfo implementation
    public partial class PackageItemInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#%3Cinit%3E(android.content.pm.PackageItemInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageItemInfo"/></param>
        public PackageItemInfo(Android.Content.Pm.PackageItemInfo arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#metaData"/>
        /// </summary>
        public Android.Os.Bundle metaData { get { return IGetField<Android.Os.Bundle>("metaData"); } set { ISetField("metaData", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#isArchived"/>
        /// </summary>
        public bool isArchived { get { return IGetField<bool>("isArchived"); } set { ISetField("isArchived", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#banner"/>
        /// </summary>
        public int banner { get { return IGetField<int>("banner"); } set { ISetField("banner", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#icon"/>
        /// </summary>
        public int icon { get { return IGetField<int>("icon"); } set { ISetField("icon", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#labelRes"/>
        /// </summary>
        public int labelRes { get { return IGetField<int>("labelRes"); } set { ISetField("labelRes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#logo"/>
        /// </summary>
        public int logo { get { return IGetField<int>("logo"); } set { ISetField("logo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#nonLocalizedLabel"/>
        /// </summary>
        public Java.Lang.CharSequence nonLocalizedLabel { get { return IGetField<Java.Lang.CharSequence>("nonLocalizedLabel"); } set { ISetField("nonLocalizedLabel", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { return IGetField<Java.Lang.String>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#packageName"/>
        /// </summary>
        public Java.Lang.String packageName { get { return IGetField<Java.Lang.String>("packageName"); } set { ISetField("packageName", value); } }
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#loadXmlMetaData(android.content.pm.PackageManager,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Res.XmlResourceParser"/></returns>
        public Android.Content.Res.XmlResourceParser LoadXmlMetaData(Android.Content.Pm.PackageManager arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.Content.Res.XmlResourceParser>("loadXmlMetaData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#loadBanner(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadBanner(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadBanner", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#loadIcon(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadIcon(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#loadLogo(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadLogo(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadLogo", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#loadUnbadgedIcon(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadUnbadgedIcon(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadUnbadgedIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#loadLabel(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadLabel(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageItemInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}