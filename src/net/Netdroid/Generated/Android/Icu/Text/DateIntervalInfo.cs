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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Text
{
    #region DateIntervalInfo
    public partial class DateIntervalInfo : Java.Lang.ICloneable, Android.Icu.Util.IFreezable<Android.Icu.Text.DateIntervalInfo>, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public DateIntervalInfo(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DateIntervalInfo(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Icu.Text.DateIntervalInfo t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo"/> to <see cref="Android.Icu.Util.Freezable"/>
        /// </summary>
        public static implicit operator Android.Icu.Util.Freezable(Android.Icu.Text.DateIntervalInfo t) => t.Cast<Android.Icu.Util.Freezable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Android.Icu.Text.DateIntervalInfo t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#getDefaultOrder()"/> 
        /// </summary>
        public bool DefaultOrder
        {
            get { return IExecuteWithSignature<bool>("getDefaultOrder", "()Z"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#getFallbackIntervalPattern()"/> <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#setFallbackIntervalPattern(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String FallbackIntervalPattern
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFallbackIntervalPattern", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setFallbackIntervalPattern", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#getIntervalPattern(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.DateIntervalInfo.PatternInfo"/></returns>
        public Android.Icu.Text.DateIntervalInfo.PatternInfo GetIntervalPattern(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Android.Icu.Text.DateIntervalInfo.PatternInfo>("getIntervalPattern", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#isFrozen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFrozen()
        {
            return IExecuteWithSignature<bool>("isFrozen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#cloneAsThawed()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object CloneAsThawed()
        {
            return IExecuteWithSignature("cloneAsThawed", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#freeze()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Freeze()
        {
            return IExecuteWithSignature("freeze", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#setIntervalPattern(java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void SetIntervalPattern(Java.Lang.String arg0, int arg1, Java.Lang.String arg2)
        {
            IExecute("setIntervalPattern", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region PatternInfo
        public partial class PatternInfo : Java.Lang.ICloneable, Java.Io.ISerializable
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            public PatternInfo(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo.PatternInfo"/> to <see cref="Java.Lang.Cloneable"/>
            /// </summary>
            public static implicit operator Java.Lang.Cloneable(Android.Icu.Text.DateIntervalInfo.PatternInfo t) => t.Cast<Java.Lang.Cloneable>();
            /// <summary>
            /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo.PatternInfo"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Android.Icu.Text.DateIntervalInfo.PatternInfo t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#getFirstPart()"/> 
            /// </summary>
            public Java.Lang.String FirstPart
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getFirstPart", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#getSecondPart()"/> 
            /// </summary>
            public Java.Lang.String SecondPart
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getSecondPart", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#firstDateInPtnIsLaterDate()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool FirstDateInPtnIsLaterDate()
            {
                return IExecuteWithSignature<bool>("firstDateInPtnIsLaterDate", "()Z");
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