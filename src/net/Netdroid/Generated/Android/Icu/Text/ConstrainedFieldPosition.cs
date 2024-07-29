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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Text
{
    #region ConstrainedFieldPosition
    public partial class ConstrainedFieldPosition
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
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#matchesField(java.text.Format.Field,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format.Field"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MatchesField(Java.Text.Format.Field arg0, object arg1)
        {
            return IExecute<bool>("matchesField", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#getLimit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLimit()
        {
            return IExecuteWithSignature<int>("getLimit", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#getStart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStart()
        {
            return IExecuteWithSignature<int>("getStart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#getFieldValue()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetFieldValue()
        {
            return IExecuteWithSignature("getFieldValue", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#getField()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.Format.Field"/></returns>
        public Java.Text.Format.Field GetField()
        {
            return IExecuteWithSignature<Java.Text.Format.Field>("getField", "()Ljava/text/Format$Field;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#getInt64IterationContext()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetInt64IterationContext()
        {
            return IExecuteWithSignature<long>("getInt64IterationContext", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#constrainClass(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        public void ConstrainClass(Java.Lang.Class arg0)
        {
            IExecuteWithSignature("constrainClass", "(Ljava/lang/Class;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#constrainField(java.text.Format.Field)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format.Field"/></param>
        public void ConstrainField(Java.Text.Format.Field arg0)
        {
            IExecuteWithSignature("constrainField", "(Ljava/text/Format$Field;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#setInt64IterationContext(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetInt64IterationContext(long arg0)
        {
            IExecuteWithSignature("setInt64IterationContext", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ConstrainedFieldPosition.html#setState(java.text.Format.Field,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format.Field"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetState(Java.Text.Format.Field arg0, object arg1, int arg2, int arg3)
        {
            IExecute("setState", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}