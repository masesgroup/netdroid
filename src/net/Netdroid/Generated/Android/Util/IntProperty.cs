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

namespace Android.Util
{
    #region IntProperty
    public partial class IntProperty
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/IntProperty.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public IntProperty(Java.Lang.String arg0)
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
        /// <see href="https://developer.android.com/reference/android/util/IntProperty.html#setValue(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetValue(object arg0, int arg1)
        {
            IExecute("setValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/IntProperty.html#set(java.lang.Object,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        public void Set(object arg0, Java.Lang.Integer arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntProperty<T>
    public partial class IntProperty<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/IntProperty.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public IntProperty(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Util.IntProperty{T}"/> to <see cref="Android.Util.IntProperty"/>
        /// </summary>
        public static implicit operator Android.Util.IntProperty(Android.Util.IntProperty<T> t) => t.Cast<Android.Util.IntProperty>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/IntProperty.html#setValue(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetValue(T arg0, int arg1)
        {
            IExecute("setValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/IntProperty.html#set(java.lang.Object,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        public void Set(T arg0, Java.Lang.Integer arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}