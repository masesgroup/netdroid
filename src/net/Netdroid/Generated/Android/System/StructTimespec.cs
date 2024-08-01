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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.System
{
    #region StructTimespec
    public partial class StructTimespec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructTimespec.html#%3Cinit%3E(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public StructTimespec(long arg0, long arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructTimespec.html#tv_nsec"/>
        /// </summary>
        public long tv_nsec { get { if (!_tv_nsecReady) { _tv_nsecContent = IGetField<long>("tv_nsec"); _tv_nsecReady = true; } return _tv_nsecContent; } }
        private long _tv_nsecContent = default;
        private bool _tv_nsecReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructTimespec.html#tv_sec"/>
        /// </summary>
        public long tv_sec { get { if (!_tv_secReady) { _tv_secContent = IGetField<long>("tv_sec"); _tv_secReady = true; } return _tv_secContent; } }
        private long _tv_secContent = default;
        private bool _tv_secReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructTimespec.html#compareTo(android.system.StructTimespec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.System.StructTimespec"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.System.StructTimespec arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/system/StructTimespec;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructTimespec.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}