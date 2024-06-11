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

namespace Android.Content.Pm
{
    #region LabeledIntent
    public partial class LabeledIntent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#%3Cinit%3E(android.content.Intent,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public LabeledIntent(Android.Content.Intent arg0, Java.Lang.String arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#%3Cinit%3E(android.content.Intent,java.lang.String,java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public LabeledIntent(Android.Content.Intent arg0, Java.Lang.String arg1, Java.Lang.CharSequence arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#%3Cinit%3E(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public LabeledIntent(Java.Lang.String arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#%3Cinit%3E(java.lang.String,java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public LabeledIntent(Java.Lang.String arg0, Java.Lang.CharSequence arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#loadIcon(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadIcon(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#getIconResource()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIconResource()
        {
            return IExecuteWithSignature<int>("getIconResource", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#getLabelResource()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLabelResource()
        {
            return IExecuteWithSignature<int>("getLabelResource", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#getNonLocalizedLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetNonLocalizedLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getNonLocalizedLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#loadLabel(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadLabel(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/LabeledIntent.html#getSourcePackage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSourcePackage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSourcePackage", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}